using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boolean.Habbo.Characters;
using Boolean.Storage;

namespace Boolean
{
    static class CharacterHandler
    {
        public static Character Authenticate(string Ticket)
        {
            Character Result = null;

            using (var Client = new DatabaseClient("SELECT * FROM characters WHERE sso_ticket = @ticket LIMIT 1"))
            {
                Client.AddParam("ticket", Ticket);

                var Row = Client.GetRow();

                try { Result = new Character(Row); }
                catch { }
            }

            return Result;
        }
    }
}
