using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Boolean.Habbo.Storage.Items.Characters
{
    class CharacterAchievement
    {
        public int Id;
        public int CharacterId;
        public int AchievementId;
        public int CurrentLevel;

        public CharacterAchievement(DataRow Row)
        {
            this.Id = (int)Row["id"];
            this.CharacterId = (int)Row["character_id"];
            this.AchievementId = (int)Row["achievement_id"];
            this.CurrentLevel = (int)Row["current_level"];
        }

        public CharacterAchievement(int Id, int CharacterId,int AchievementId, int CurrentLevel)
        {
            this.Id = Id;
            this.CharacterId = CharacterId;
            this.AchievementId = AchievementId;
            this.CurrentLevel = CurrentLevel;
        }
    }
}
