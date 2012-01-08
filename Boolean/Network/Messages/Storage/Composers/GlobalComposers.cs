using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Boolean.Network.Messages.Interfaces;
using Boolean.Network.Messages.Types;

namespace Boolean.Network.Messages.Storage.Composers
{
    class MOTDNotificationComposer : IMessageComposer
    {
        public Types.OutMessage Invoke(params object[] Parameters)
        {
            var Message = new OutMessage(810);
            Message.Append(Parameters[0].ToString().Split((char)13,(char)10).Length);
            Message.Append(Parameters[0]);
            return Message;
        }
    }
}
