using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Boolean.Enumerables;

namespace Boolean
{
    static class CommandHandler
    {
        public static SerializeResult Serialize()
        {
            try { }
            catch
            {
                return SerializeResult.Broken;
            }

            return SerializeResult.Finished;
        }
    }
}
