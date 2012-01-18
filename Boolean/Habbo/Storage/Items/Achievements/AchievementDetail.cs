using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Boolean.Habbo.Storage.Items.Achievements
{
    class AchievementDetail
    {
        public int Id;
        public int AchievementId;
        public int Level;
        public int RequiredAmmount;

        public AchievementDetail(DataRow Row)
        {
            this.Id = (int)Row["id"];
            this.AchievementId = (int)Row["achievement_id"];
            this.Level = (int)Row["level"];
            this.RequiredAmmount = (int)Row["required_amount"];
        }
    }
}
