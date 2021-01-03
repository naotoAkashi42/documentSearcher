using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace documentSearcher.Core.Funtions
{
    class AutoComplemeterOperator
    {
        private TextBox _textBox;
        public AutoComplemeterOperator(TextBox textBox)
        {
            _textBox = textBox;
        }

        public void SetAutoComplementer()
        {
            _textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            _textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
