using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace documentSearcher.Core.Command
{
    class Invalid : ICommand
    {
        public string CommandName { get; } = "";

        public void Execute(IEnumerable<string> args)
        {
        }
    }
}
