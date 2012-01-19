using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Boolean.Network.Messages.Interfaces;
using Boolean.Network.Messages.Types;

namespace Boolean.Network.Messages.Storage.Composers
{
    class BadgePointLimitsComposer : IMessageComposer
    {
        public OutMessage Invoke(params object[] Parameters)
        {
            var Message = new OutMessage(627);
            Message.Append(AchievementHandler.Achievements.Count);

            foreach (var Achievement in AchievementHandler.Achievements.Values)
            {
                var Items = StorageHandler.GetAchievementDetailsSorted(Achievement.Id);

                Message.Append(Achievement.Badge);
                Message.Append(Items.Count());

                foreach (var Item in (from item in Items orderby item.Level ascending select item))
                {
                    Message.Append(Item.Level);
                    Message.Append(Item.RequiredAmmount);
                }
            }

            return Message;
        }
    }
}
