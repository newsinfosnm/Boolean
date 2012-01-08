using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boolean.Helpers.Commands
{
    interface IConsoleCommand
    {
        string Id { get; }
        void Invoke();
    }
}
