using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Boolean.Network.Messages.Interfaces;
using Boolean.Network.Messages.Storage.Composers;

namespace Boolean.Network.Messages.Storage.Events
{
    class GetOfficialRoomsMessageEvent : IMessageEvent
    {
        public int Id
        {
            get { return 380; }
        }

        public void Invoke(Transmission.Session Session, Types.InMessage Message)
        {
            MessageHandler.HandleComposer(Session, new OfficialRoomsComposer());
        }
    }
}
