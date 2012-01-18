using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Boolean.Storage;
using Boolean.Habbo.Navigator;

namespace Boolean
{
    static class NavigatorHandler
    {
        public static Dictionary<int, NavigatorPublic> Publics;

        public static void Serialize()
        {
            Publics = new Dictionary<int, NavigatorPublic>();
            
            using (var Client = new DatabaseClient("SELECT * FROM navigator_publics"))
            {
                foreach (DataRow Row in Client.GetTable().Rows)
                {
                    var Item = new NavigatorPublic(Row);

                    Publics.Add(Item.Id, Item);
                }
            }
        }

        public static int Validate()
        {
            var Result = new int();

            foreach (var kvp in Publics)
            {
                if (kvp.Value.ParentId > 0)
                {
                    if (Publics.ContainsKey(kvp.Value.ParentId))
                    {
                        Result++;
                    }
                }
                else Result++;
            }

            return Result;
        }

        public static IEnumerable<NavigatorPublic> GetChilds(int Id)
        {
            var Result = new List<NavigatorPublic>();

            foreach (var Item in Publics.Values)
            {
                if (Item.ParentId == Id)
                {
                    Result.Add(Item);
                }
            }

            return Result;
        }
    }
}
