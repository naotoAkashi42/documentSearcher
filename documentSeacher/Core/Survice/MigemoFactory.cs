using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaoriYa.Migemo;

namespace documentSearcher.Core.Survice
{
    static class MigemoFactory
    {
        public static Migemo Create()
        {
            var migemo = new Migemo("./dict/cp932/migemo-dict");
            migemo.OperatorNewLine = @"\s*";
            return migemo;
        }
    }
}
