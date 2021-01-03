using KaoriYa.Migemo;
using documentSearcher.Core.Command;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using documentSearcher.Properties;


namespace documentSearcher.UI
{
    public partial class MainForm : Form
    {
        private IMainformNeed _need;

        public MainForm(IMainformNeed need)
        {
            _need = need;
            InitializeComponent();
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Equals(string.Empty) || e.KeyCode != Keys.Enter) return;

            _commnadProcess(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _need.SetAutoCompementer(textBox1);
        }

        private void _commnadProcess(string inputText)
        {
            _need.Command.CreateCommand(inputText);
            _need.Command.Excute();
            textBox1.Clear();
        }

        private void _topMost()
        {
            this.TopMost = true;
        }
    }
}
