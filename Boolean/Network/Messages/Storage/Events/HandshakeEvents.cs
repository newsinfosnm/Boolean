using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Boolean.Network.Messages.Interfaces;
using Boolean.Network.Messages.Storage.Composers;

namespace Boolean.Network.Messages.Storage.Events
{
    class InitCryptoMessageEvent : IMessageEvent
    {
        public int Id
        {
            get { return 206; }
        }

        public void Invoke(Transmission.Session Session, Types.InMessage Message)
        {
            MessageHandler.HandleComposer(Session, new SessionParamsMessageComposer());
        }
    }

    class SSOTicketMessageEvent : IMessageEvent
    {
        public int Id
        {
            get { return 415;  }
        }

        public void Invoke(Transmission.Session Session, Types.InMessage Message)
        {
            var Ticket = Message.GetString();
            var Character = CharacterHandler.Authenticate(Ticket);

            if (Character != null)
            {
                Solution.AppendPaint(ConsoleColor.DarkCyan);
                Solution.AppendLine("Character: Authenticated({0})", Character.Username);

                MessageHandler.HandleComposer(Session, new AuthenticationOKMessageComposer());

                Session.Character = Character;
            }
            else
            {
                Solution.AppendPaint();
                Solution.AppendLine("Authenticate: Unknown: {0}", Ticket);

                SessionHandler.CloseClientSocket(Session.Args);
            }
        }
    }

    class LatencyPingRequestMessageEvent : IMessageEvent
    {
        public int Id
        {
            get { return 315; }
        }

        public void Invoke(Transmission.Session Session, Types.InMessage Message)
        {
            MessageHandler.HandleComposer(Session, new PingMessageComposer(), Message.GetInt32());
        }
    }

    class LatencyPingReportMessageEvent : IMessageEvent
    {
        public int Id
        {
            get { return 316; }
        }

        public void Invoke(Transmission.Session Session, Types.InMessage Message)
        {
            var Ping = ((Message.GetInt32() + Message.GetInt32()) / 2);

            if (Ping > int.Parse(Settings.GetValue("TCP.Sessions.MaxPing")))
            {
                Solution.AppendPaint();
                Solution.AppendLine("Session: Closed({0}) Ping to high({1})",Session.Id, Ping);
               // SessionHandler.CloseClientSocket(Session.Args);
            }
        }
    }
}
