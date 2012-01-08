using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Boolean.Habbo.Storage.Items
{
    class CharacterIgnore
    {
        public int Id;
        public string CharacterName;
        public string IgnoreName;

        public CharacterIgnore(DataRow Row)
        {
            this.Id = (int)Row["id"];
            this.CharacterName = (string)Row["charactername"];
            this.IgnoreName = (string)Row["ignorename"];
        }

        public CharacterIgnore(int Id, string CharacterName, string IgnoreName)
        {
            this.Id = Id;
            this.CharacterName = CharacterName;
            this.IgnoreName = IgnoreName;
        }
    }
}
