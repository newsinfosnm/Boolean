using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boolean.Adapters
{
    static class StringAdapter
    {
        public static string CleanQuotesHigh(string Base)
        {
            return Base.Replace("\"", string.Empty);
        }

        public static bool GetBoolean(object Item)
        {
            return int.Parse(Item.ToString()) == 1;
        }
    }
}
