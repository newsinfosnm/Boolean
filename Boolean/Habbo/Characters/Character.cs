using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Boolean.Habbo.Characters
{
    class Character
    {
        public int Id;
        public string Username;

        public int Credits;
        public int Pixels;
        public int Soundvolume;

        public Character(DataRow Row)
        {
            this.Id = (int)Row["id"];
            this.Username = (string)Row["username"];
            this.Credits = (int)Row["credits"];
            this.Pixels = (int)Row["pixels"];
            this.Soundvolume = (int)Row["sound_volume"];
        }
    }
}
