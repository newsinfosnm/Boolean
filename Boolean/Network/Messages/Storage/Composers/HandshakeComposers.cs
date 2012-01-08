using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Boolean.Network.Messages.Interfaces;
using Boolean.Network.Messages.Types;

namespace Boolean.Network.Messages.Storage.Composers
{
    class SessionParamsMessageComposer : IMessageComposer
    {
        Types.OutMessage IMessageComposer.Invoke(params object[] Parameters)
        {
            var Message = new OutMessage(257);
            var Length = 9;
            var Random = new Random();

            Message.Append(Length);

            for (int i = 0; i <= 9; i++)
            {
                if (i == 2)
                {
                    Message.Append(3);
                }
                else if (i == 3)
                {
                    Message.Append(2);
                }
                else
                {
                    Message.Append(i);
                }

                if (i == 5)
                {
                    Message.Append("dd-MM-yyyy");
                }
                else if (i == 8)
                {
                    Message.Append("http://google.com");
                }
                else
                {
                    Message.Append(Random.Next(0, 2));
                }
            }

            return Message;
        }
    }

    class AuthenticationOKMessageComposer : IMessageComposer
    {
        public OutMessage Invoke(params object[] Parameters)
        {
            return new OutMessage(3);
        }
    }

    class PingMessageComposer : IMessageComposer
    {
        public OutMessage Invoke(params object[] Parameters)
        {
            var Message = new OutMessage(354);
            Message.Append(Parameters[0]);
            return Message;
        }
    }

}
