using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boolean.Network.Messages.Types;
using Boolean.Network.Transmission;

namespace Boolean.Network.Messages.Interfaces
{
    interface IMessageEvent
    {
        int Id { get; }
        void Invoke(Session Session, InMessage Message);
    }
}
