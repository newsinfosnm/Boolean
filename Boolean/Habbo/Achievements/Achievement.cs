using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Boolean.Adapters;
using Boolean.Network.Messages.Types;
using Boolean.Habbo.Characters;
using Boolean.Habbo.Storage.Items.Characters;

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
            var Achievements = StorageHandler.GetCharacterAchievements(Character.Id);
            var Details = StorageHandler.GetAchievementDetailsSorted(Id);
            var QueryA = (from item in Achievements where item.AchievementId == Id select item);
            var MaxLevel = Details.Count() > 0 ? Details.Count() : 1;

            var MyProgress = QueryA.Count() > 0 ? QueryA.First() : new CharacterAchievement(-1, Character.Id, Id, 0);
            var CurrentLevel = MyProgress.CurrentLevel;
            var NextLevel = (CurrentLevel + 1);

            if (NextLevel > MaxLevel)
            {
                NextLevel= MaxLevel;
            }

            if (CurrentLevel >= MaxLevel)
            {
                CurrentLevel = MaxLevel;
            }

            var QueryB = (from item in Details where item.Level == NextLevel select item);

            var NextRequired = QueryB.Count() > 0 ?  QueryB.First().RequiredAmmount : 1;

            Message.Append(Id);
            Message.Append(NextLevel);
            Message.Append(GetBadge(NextLevel));
            Message.Append(NextRequired);
            Message.Append(GetPixelReward(NextLevel));
            Message.Append(0); // TODO <> BadgeId
            Message.Append(0); // TODO <> GotAlready
            Message.Append(CurrentLevel == MaxLevel);
            Message.Append(AchievementHandler.GetCategory(ParentId).Caption.ToLower());
            Message.Append(MaxLevel);
        }

        public int GetPixelReward(int Level)
        {
            return (int)(PixelReward * (Level * Formula));
        }

        public string GetBadge(int Level)
        {
            return TideBadge ? string.Format("{0}{1}", Badge, Level) : Badge;
        }
    }
}
