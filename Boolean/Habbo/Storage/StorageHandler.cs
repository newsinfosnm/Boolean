using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Boolean.Enumerables;
using Boolean.Habbo.Storage.Items;
using Boolean.Storage;

namespace Boolean
{
    static class StorageHandler
    {
        public static Dictionary<int, CharacterIgnore> CharacterIgnores;

        public static SerializeResult Serialize()
        {
            NavigatorHandler.Serialize();

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
            }
            catch { return SerializeResult.Broken; }

            return SerializeResult.Finished;
        }

        public static IEnumerable<string> GetCharacterIgnores(string Username)
        {
            return (from kvp in CharacterIgnores where kvp.Value.CharacterName == Username select kvp.Value.IgnoreName);
        }
    }
}
