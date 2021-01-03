using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace documentSearcher.Core.Command
{
    public interface ICommand
    {
        string CommandName { get; }
        void Execute(IEnumerable<string> args);
    }
}
