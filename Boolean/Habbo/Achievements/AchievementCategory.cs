using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Boolean.Habbo.Achievements
{
    class AchievementCategory
    {
        public int Id;
        public string Caption;

        public AchievementCategory(DataRow Row)
        {
            this.Id = (int)Row["id"];
            this.Caption = (string)Row["caption"];
        }
    }
}
