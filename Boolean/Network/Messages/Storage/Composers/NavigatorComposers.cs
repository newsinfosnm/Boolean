using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Boolean.Network.Messages.Interfaces;
using Boolean.Network.Messages.Types;

namespace Boolean.Network.Messages.Storage.Composers
{
    class OfficialRoomsComposer : IMessageComposer
    {
        public OutMessage Invoke(params object[] Parameters)
        {
            var Message = new OutMessage(450);
            Message.Append(NavigatorHandler.Publics.Count);

            foreach (var Public in NavigatorHandler.GetChilds(-1))
            {
                Public.GetResponse(Message);

                foreach (var Child in NavigatorHandler.GetChilds(Public.Id))
                {
                    Child.GetResponse(Message);
                }
            }

            return Message;
        }
    }
}
