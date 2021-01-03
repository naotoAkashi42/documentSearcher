using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace documentSearcher.Core.Survice
{
    class StreramFactory
    {
        public StreramFactory()
        {
        }

        public static StreamReader CreateStreamReader(string filePath)
        {
            return new StreamReader(filePath, true);
        }

        public static StreamWriter CreateStreamWriter(string filePath)
        {
            return new StreamWriter(filePath, true);
        }
    }
}
