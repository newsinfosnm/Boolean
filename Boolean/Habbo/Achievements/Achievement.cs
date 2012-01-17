using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Boolean.Adapters;
using Boolean.Network.Messages.Types;
using Boolean.Habbo.Characters;

namespace Boolean.Habbo.Achievements
{
    class Achievement
    {
        public int Id;
        public int ParentId;
        public int RankRequired;
        public int PixelReward;

        public string Badge;
        public double Formula;
        public bool TideBadge;

        public Achievement(DataRow Row)
        {
            this.Id = (int)Row["id"];
            this.ParentId = (int)Row["parent_id"];
            this.RankRequired = (int)Row["rank_required"];
            this.PixelReward = (int)Row["pixel_reward"];
            this.Badge = (string)Row["badge"];
            this.Formula = (double)Row["formula"];
            this.TideBadge = StringAdapter.GetBoolean(Row["tide_badge"].ToString());
        }

        public void GetResponse(OutMessage Message, Character Character)
        {
        }
    }
}
