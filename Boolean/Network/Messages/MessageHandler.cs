using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using Boolean.Enumerables;
using Boolean.Network.Messages.Interfaces;
using Boolean.Network.Transmission;
using Boolean.Adapter;
using Boolean.Network.Messages.Types;

namespace Boolean
{
    class MessageHandler
    {
        public static Dictionary<int, IMessageEvent> Events;
        public static byte[] PolicyFileRequest;

        public static SerializeResult Serialize()
        {
            if (!File.Exists("PolicyFileRequest.xml"))
            {
                return SerializeResult.Broken;
            }

            PolicyFileRequest = Encoding.Default.GetBytes((File.ReadAllText("PolicyFileRequest.xml", Encoding.Default).Replace("\"\"", "\"/xml/dtds/cross-domain-policy.dtd\"") + "\x0"));

            Events = new Dictionary<int, IMessageEvent>();

            try
            {
                var Type = typeof(IMessageEvent);

                foreach (var AssemblyType in Assembly.GetExecutingAssembly().GetTypes())
                {
                    if (AssemblyType.GetInterfaces().Contains(Type))
                    {
                        var Constructed = (AssemblyType.GetConstructor(new Type[] {}).Invoke(new object[] {}) as IMessageEvent);

                        if (!Events.ContainsKey(Constructed.Id))
                        {
                            Events.Add(Constructed.Id,Constructed);
                        }
                    }
                }

                Solution.AppendLine("MessageHandler: Saved {0} Event-actions.",Events.Count);
            }
            catch { return SerializeResult.Broken; }

            return SerializeResult.Finished;
        }

        public static void HandleBytes(Session Session, ref byte[] Bytes)
        {
            if (Encoding.ASCII.GetString(Bytes) == "<policy-file-request/>\x0")
            {
                Session.Send(PolicyFileRequest);
                return;
            }
            
            var Pointer = new int();

            try
            {
                for (; Pointer < Bytes.Length; )
                {
                    var MessageLength = Base64Encoding.DecodeInt32(new byte[] { Bytes[Pointer++], Bytes[Pointer++], Bytes[Pointer++] });
                    var MessageId = Base64Encoding.DecodeInt32(new byte[] { Bytes[Pointer++], Bytes[Pointer++] });

                    var ContextLength = (MessageLength - 2);
                    var Context = new byte[ContextLength];

                    Array.Copy(Bytes, Pointer, Context, 0, ContextLength);

                    Pointer += ContextLength;

                    var InMessage = new InMessage(MessageId, Context);

                    HandleEvent(Session, InMessage);
                }
            }
            catch { }
        }

        public static void HandleEvent(Session Session, InMessage InMessage)
        {
            if (Session.Character == null)
            {
                if (InMessage.Id != 206 && InMessage.Id != 415)
                {
                    Solution.AppendPaint();
                    Solution.AppendLine("MessageHandler: ({0})Tried to bypass authenticating.", Session.Id);
                    SessionHandler.CloseClientSocket(Session.Args);
                    return;
                }
            }

            if (Events.ContainsKey(InMessage.Id))
            {
                var Event = Events[InMessage.Id];
                var EventName = Event.ToString().Split('.')[Event.ToString().Split('.').Count() - 1];

                try
                {
                    Event.Invoke(Session, InMessage);
                }
                catch (Exception e)
                {
                    Solution.AppendPaint();
                    Solution.AppendLine(e.ToString());
                }

                Solution.AppendLine("HandleEvent: ({0}){1}({2})", Session.Id, EventName, InMessage.Id);
            }
            else
            {
                Solution.AppendLine("HandleEvent: ({0}){1}({2})", Session.Id, Encoding.ASCII.GetString(InMessage.Context), InMessage.Id);
            }
        }

        public static void HandleComposer(Session Session, IMessageComposer Composer, params object[] Parameters)
        {
            var Bytes = Composer.Invoke(Parameters).Result;

            if (Bytes.Count() > 0)
            {
                Session.Send(Bytes);
            }
        }
    }
}
