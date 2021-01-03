using KaoriYa.Migemo;
using documentSearcher.Core.Funtions;
using documentSearcher.UI;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace documentSearcher.Coodinator
{
    class MainformAgent : IMainformNeed
    {
        private RegistlationManger _manager;
        private CommandManager _commandManager;

        public CommandManager Command => _commandManager;

        public MainformAgent()
        {
            _manager = new RegistlationManger();
            _commandManager = new CommandManager();
        }

        public void SetAutoCompementer(TextBox textBox)
        {
            var autoComplementer = new AutoComplemeterOperator(textBox);
            autoComplementer.SetAutoComplementer();
        }

    }
}
