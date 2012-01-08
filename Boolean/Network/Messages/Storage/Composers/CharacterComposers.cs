using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Boolean.Network.Messages.Interfaces;
using Boolean.Network.Messages.Types;
using Boolean.Habbo.Characters;

namespace Boolean.Network.Messages.Storage.Composers
{
    class UserObjectComposer : IMessageComposer
    {
        public OutMessage Invoke(params object[] Parameters)
        {
            var Message = new OutMessage(5);
            var Character = (Character)Parameters[0];

            Message.Append(Character.Id + string.Empty);
            Message.Append(Character.Username);
            Message.Append(string.Empty); // Figure
            Message.Append(string.Empty); // Gender U
            Message.Append(string.Empty); // Motto
            Message.Append(string.Empty); // Figure
            Message.Append(string.Empty); // Facebook Name?
            Message.Append(true); // ?
            Message.Append(0); // Respect Received
            Message.Append(3); // Respect Left
            Message.Append(3); // Respect Left Animals

            return Message;
        }
    }

    class CreditBalanceComposer : IMessageComposer
    {
        public OutMessage Invoke(params object[] Parameters)
        {
            var Message = new OutMessage(6);
            Message.Append(Parameters[0] + string.Empty);
            return Message;
        }
    }

    class IgnoredUsersMessageComposer : IMessageComposer
    {
        public OutMessage Invoke(params object[] Parameters)
        {
            var Items = Parameters[0] as IEnumerable<string>;
            var Message = new OutMessage(420);
            Message.Append(Items.Count());

            foreach (var Item in Items)
            {
                Message.Append(Item);
            }

            return Message;
        }
    }

}
