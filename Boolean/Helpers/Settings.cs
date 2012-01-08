using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Boolean.Enumerables;
using Boolean.Adapters;

namespace Boolean
{
    static class Settings
    {
        private const string SETTINGS_PATH = "Settings.ini";
        private static Dictionary<string, string> Storage;

        public static SerializeResult Serialize()
        {
            if (!File.Exists(SETTINGS_PATH))
            {
                return SerializeResult.Broken;
            }

            Storage = new Dictionary<string, string>();

            foreach (var Line in File.ReadAllLines(SETTINGS_PATH))
            {
                if (Line.StartsWith("#") || string.IsNullOrEmpty(Line)) { continue; }

                try
                {
                    var Turnage = Line.Split(':');

                    Storage[StringAdapter.CleanQuotesHigh(Turnage[0].Substring(0, Turnage[0].Length - 1))] = StringAdapter.CleanQuotesHigh(Turnage[1].Substring(1));
                }
                catch { }
            }

            return SerializeResult.Finished;
        }

        public static string GetValue(string Key)
        {
            try { return Storage[Key]; }
            catch { return string.Empty; }
        }
    }
}
