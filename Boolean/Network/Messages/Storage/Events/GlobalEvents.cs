using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Boolean.Network.Messages.Interfaces;
using Boolean.Network.Messages.Storage.Composers;

namespace Boolean.Network.Messages.Storage.Events
{
    class GetMOTDMessageEvent : IMessageEvent
    {
        public int Id
        {
            get { return 3110; }
        }

        public void Invoke(Transmission.Session Session, Types.InMessage Message)
        {
            MessageHandler.HandleComposer(Session, new MOTDNotificationComposer(), 
                string.Format("Welcome to Project Boolean.\r\nYour socket-id: {0}\rYour socket-info: {1}\rYour buffer-size: {2}\rYour addressfamily: {3}",
                Session.Id,
                Session.Socket.RemoteEndPoint,
                Session.Socket.ReceiveBufferSize,
                Session.Socket.AddressFamily));
        }
    }
}
