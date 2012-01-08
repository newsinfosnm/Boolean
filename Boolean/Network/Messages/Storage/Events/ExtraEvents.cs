using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Boolean.Network.Messages.Interfaces;
using Boolean.Network.Messages.Storage.Composers;

namespace Boolean.Network.Messages.Storage.Events
{
    class EventLogMessageEvent : IMessageEvent
    {
        public int Id
        {
            get { return 482; }
        }

        public void Invoke(Transmission.Session Session, Types.InMessage Message){}
    }

    class PerformanceLogMessageEvent : IMessageEvent
    {
        public int Id
        {
            get { return 421; }
        }

        public void Invoke(Transmission.Session Session, Types.InMessage Message) { }
    }
}
