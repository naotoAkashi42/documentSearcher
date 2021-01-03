using documentSearcher.Core.Command;
using System.Collections.Generic;
using static documentSearcher.Desing.Define;

namespace documentSearcher.Coodinator
{
    public class CommandManager
    {
        private ICommand _command;
        private List<string> _args;

        public CommandManager()
        {
        }

        public void CreateCommand(string inputText)
        {
            string commandText;
            _args = new List<string>();
            try
            {
                var temp = inputText.Split();
                commandText = temp[0];
                
                for(var index = 1; index < temp.Length; index++)
                {
                    _args.Add(temp[index]);
                }

            }
            catch
            {
                _command = new Invalid();
                return;
            }

            var commandType = ConvToCommand(commandText);

            switch (commandType)
            {
                case (CommandType.Add):
                    _command =  new Add();
                    break;
                case (CommandType.Find):
                    _command = new Find();
                    break;

                default:
                    _command = new Invalid();
                    break;
            }
        }

        public void Excute()
        {
            if (_command == null) return;
            _command.Execute(_args);
        }

        private CommandType ConvToCommand(string commandText)
        {
            if (IsAddCommand(commandText)) return CommandType.Add;
            if (IsFindCommand(commandText)) return CommandType.Find;

            return CommandType.Invalid;
        }

        private static bool IsAddCommand(string commandName)
        {
            return commandName.Equals(Properties.Resources.AddCommand);
        }

        private static bool IsFindCommand(string commandName)
        {
            return commandName.Equals(Properties.Resources.FindCommand);
        }
    }
}
