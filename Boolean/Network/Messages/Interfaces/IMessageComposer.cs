using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Boolean.Network.Messages.Types;

namespace Boolean.Network.Messages.Interfaces
{
    interface IMessageComposer
    {
        OutMessage Invoke(params object[] Parameters);
    }
}
