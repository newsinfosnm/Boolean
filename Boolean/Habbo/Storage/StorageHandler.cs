using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Boolean.Enumerables;
using Boolean.Storage;
using Boolean.Habbo.Storage.Items.Characters;
using Boolean.Habbo.Storage.Items.Achievements;

namespace Boolean
{
    static class StorageHandler
    {
        public static Dictionary<int, CharacterIgnore> CharacterIgnores;
        public static Dictionary<int, CharacterAchievement> CharacterAchievements;

        public static Dictionary<int, AchievementDetail> AchievementDetails;

        public static SerializeResult Serialize()
        {
            NavigatorHandler.Serialize();
            AchievementHandler.Serialize();

            try
            {
                CharacterIgnores = new Dictionary<int, CharacterIgnore>();

                using (var Adapter = new DatabaseClient("SELECT * FROM character_ignores"))
                {
                    var Table = Adapter.GetTable();

                    foreach (DataRow Row in Table.Rows)
                    {
                        var Item = new CharacterIgnore(Row);

                        CharacterIgnores.Add(Item.Id, Item);
                    }
                }

                CharacterAchievements = new Dictionary<int, CharacterAchievement>();

                using (var Adapter = new DatabaseClient("SELECT * FROM character_achievements"))
                {
                    var Table = Adapter.GetTable();

                    foreach (DataRow Row in Table.Rows)
                    {
                        var Item = new CharacterAchievement(Row);

                        CharacterAchievements.Add(Item.Id, Item);
                    }
                }

                AchievementDetails = new Dictionary<int, AchievementDetail>();

                using (var Adapter = new DatabaseClient("SELECT * FROM achievements_details"))
                {
                    var Table = Adapter.GetTable();

                    foreach (DataRow Row in Table.Rows)
                    {
                        var Item = new AchievementDetail(Row);

                        AchievementDetails.Add(Item.Id, Item);
                    }
                }
            }
            catch { return SerializeResult.Broken; }

            return SerializeResult.Finished;
        }

        public static IEnumerable<string> GetCharacterIgnores(string Username)
        {
            var Result = new List<string>();

            foreach (var Item in CharacterIgnores.Values)
            {
                if (Item.CharacterName == Username)
                {
                    Result.Add(Item.IgnoreName);
                }
            }

            return Result;
        }

        public static IEnumerable<CharacterAchievement> GetCharacterAchievements(int Id)
        {
            var Result = new List<CharacterAchievement>();

            foreach (var Item in CharacterAchievements.Values)
            {
                if (Item.CharacterId == Id)
                {
                    Result.Add(Item);
                }
            }

            return Result;
        }

        public static IEnumerable<AchievementDetail> GetAchievementDetailsSorted(int AchievementId)
        {
            var Result = new List<AchievementDetail>();

            foreach (var Item in AchievementDetails.Values)
            {
                if (Item.AchievementId == AchievementId)
                {
                    Result.Add(Item);
                }
            }

            return Result;
        }
    }
}
