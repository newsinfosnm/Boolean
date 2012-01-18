using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Boolean.Habbo.Achievements;
using Boolean.Storage;
using Boolean.Habbo.Characters;

namespace Boolean
{
    static class AchievementHandler
    {
        public static Dictionary<int, Achievement> Achievements;
        public static Dictionary<int, AchievementCategory> AchievementCategorys;

        public static void Serialize()
        {
            Achievements = new Dictionary<int, Achievement>();

            using (var Client = new DatabaseClient("SELECT * FROM achievements ORDER BY parent_id ASC"))
            {
                foreach (DataRow Row in Client.GetTable().Rows)
                {
                    var Item = new Achievement(Row);

                    Achievements.Add(Item.Id, Item);
                }
            }

            AchievementCategorys = new Dictionary<int, AchievementCategory>();

            using (var Client = new DatabaseClient("SELECT * FROM achievements_categorys"))
            {
                foreach (DataRow Row in Client.GetTable().Rows)
                {
                    var Item = new AchievementCategory(Row);

                    AchievementCategorys.Add(Item.Id, Item);
                }
            }
        }

        public static IEnumerable<Achievement> GetAchievements(Character Character)
        {
            var Result = new List<Achievement>();

            foreach (var Item in Achievements.Values)
            {
                if (!AchievementCategorys.ContainsKey(Item.ParentId))
                {
                    continue;
                }

                if (Character.Rank >= Item.RankRequired)
                {
                    Result.Add(Item);
                }
            }

            return Result;
        }

        public static AchievementCategory GetCategory(int Id)
        {
            try { return AchievementCategorys[Id]; }
            catch { return null; }
        }
    }
}
