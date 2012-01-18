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
            return (from kvp in CharacterIgnores where kvp.Value.CharacterName == Username select kvp.Value.IgnoreName);
        }

        public static IEnumerable<CharacterAchievement> GetCharacterAchievements(int Id)
        {
            return (from kvp in CharacterAchievements where kvp.Value.CharacterId == Id select kvp.Value);
        }

        public static IEnumerable<AchievementDetail> GetAchievementDetailsSorted(int AchievementId)
        {
            return (from kvp in AchievementDetails where kvp.Value.AchievementId == AchievementId orderby kvp.Value.Level ascending select kvp.Value);
        }
    }
}
