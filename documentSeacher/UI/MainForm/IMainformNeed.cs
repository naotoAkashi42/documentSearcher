using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaoriYa.Migemo;
using documentSearcher.Coodinator;

namespace documentSearcher.UI
{
    public interface IMainformNeed
    {
        void SetAutoCompementer(TextBox textBox);

        CommandManager Command { get; }
    }
}
