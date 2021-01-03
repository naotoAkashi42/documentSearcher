using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using documentSearcher.Core.Survice;

namespace documentSearcher.Core.Funtions
{
    class RegistlationManger
    {
        private readonly string _registFilePath = @"C:\Users\aksh0\OneDrive\デスクトップ\migemoTest\migemoTest\bin\Debug\doc\regist.txt";
        public void Write(string registTarget)
        {
            using (var streamWriter = StreramFactory.CreateStreamWriter(_registFilePath))
            {
                streamWriter.WriteLine(registTarget);
            }
        }

        public string Read()
        {
            string registPath;
            using (var sreamReader = StreramFactory.CreateStreamReader(_registFilePath))
            {
                registPath = sreamReader.ReadToEnd();
            }
            return registPath;
        }
    }
}
