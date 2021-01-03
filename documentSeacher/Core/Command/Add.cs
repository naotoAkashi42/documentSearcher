using documentSearcher.Core.Survice;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace documentSearcher.Core.Command
{
    class Add : ICommand
    {
        public string CommandName { get; } = "add";

        private readonly string _registlationPath = GetFolderPath(SpecialFolder.ApplicationData) + @"\registlation.txt";

        public void Execute(IEnumerable<string> args)
        {
            var arg = args.ToList()[0];

            if (!IsExistDataFile()) 
            {
                File.Create(_registlationPath).Close();
            }

            using (var streamWriter = StreramFactory.CreateStreamWriter(_registlationPath))
            {
                streamWriter.WriteLine(arg);
            }
        }

        private bool IsExistDataFile()
        {
            return File.Exists(_registlationPath);
        }
    }
}
