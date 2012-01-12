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
            var Length = (int)(Parameters[0].ToString().Length / 720);

            if (Length <= 0)
            {
                Length = 1;
            }

            var Message = new OutMessage(810);
            Message.Append(Length);
            Message.Append(Parameters[0]);
            return Message;
        }
    }
}
