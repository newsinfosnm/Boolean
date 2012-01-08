using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Boolean.Network.Messages.Interfaces;
using Boolean.Network.Messages.Storage.Composers;

namespace Boolean.Network.Messages.Storage.Events
{
    class InfoRetrieveMessageEvent : IMessageEvent
    {
        public int Id
        {
            get { return 7; }
        }

        public void Invoke(Transmission.Session Session, Types.InMessage Message)
        {
            MessageHandler.HandleComposer(Session, new UserObjectComposer(), Session.Character);
        }
    }

    class GetCreditsInfoEvent : IMessageEvent
    {
        public int Id
        {
            get { return 8; }
        }

        public void Invoke(Transmission.Session Session, Types.InMessage Message)
        {
            MessageHandler.HandleComposer(Session, new CreditBalanceComposer(), Session.Character.Credits);
        }
    }

    class GetIgnoredUsersMessageEvent : IMessageEvent
    {
        public int Id
        {
            get { return 321; }
        }

        public void Invoke(Transmission.Session Session, Types.InMessage Message)
        {
            MessageHandler.HandleComposer(Session, new IgnoredUsersMessageComposer(), StorageHandler.GetCharacterIgnores(Session.Character.Username));
        }
    }
}
