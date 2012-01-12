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

        public static IEnumerable<NavigatorPublic> GetChilds(int Id)
        {
            return (from kvp in Publics where kvp.Value.ParentId == Id select kvp.Value);
        }
    }
}
