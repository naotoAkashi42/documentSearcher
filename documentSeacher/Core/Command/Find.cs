using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using documentSearcher.Core.Survice;
using KaoriYa.Migemo;
using documentSearcher.UI;
using static System.Environment;
using System.Diagnostics;

namespace documentSearcher.Core.Command
{
    class Find : ICommand
    {
        
        public Find()
        {
            _migmemo = MigemoFactory.Create();
        }
        public string CommandName => "find";

        private readonly Migemo _migmemo;
        private readonly string _registlationPath = GetFolderPath(SpecialFolder.ApplicationData) + @"\registlation.txt";

        public void Execute(IEnumerable<string> args)
        {
            var arg = args.ToList()[0];
            var regex = _migmemo.GetRegex(arg);

            foreach (var s in GetRegistlations())
            {
                Debug.WriteLine(s);
                var t = regex.Match(s).ToString();
                regex.IsMatch(s);
            }

            string[] matches = GetRegistlations().Select(s => s).Where(s => s.Contains(regex.Match(s).ToString()) 
                       && !string.IsNullOrEmpty(regex.Match(s).ToString())  || s.IndexOf(arg, StringComparison.OrdinalIgnoreCase) >= 0).ToArray();

            using (var form = new CandidateForm(matches))
            {
                form.ShowDialog();
            }
        }
        
        private IEnumerable<string> GetRegistlations()
        {
            string line;
            var registlations = new List<string>();
            using (var streamReader = StreramFactory.CreateStreamReader(_registlationPath))
            {
                while((line = streamReader.ReadLine()) != null)
                {
                    registlations.Add(line);
                }
            }
            return registlations;
        }
    }
}
