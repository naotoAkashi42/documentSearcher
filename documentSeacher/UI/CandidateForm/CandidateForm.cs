using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace documentSearcher.UI
{
    public partial class CandidateForm : Form
    {
        public CandidateForm(string[] candidate)
        {
            InitializeComponent();
            InitListBox(candidate);

            _CandidateListBox.Click += ListBox1_Click;
            _CandidateListBox.KeyDown += _CandidateListBox_KeyDown;
        }

        private void _CandidateListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                System.Diagnostics.Process.Start("EXPLORER.EXE", _CandidateListBox.SelectedItem.ToString());
                this.Close();
            }
        }

        private void ListBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXPLORER.EXE", _CandidateListBox.SelectedItem.ToString());
            this.Close();
        }

        private void InitListBox(string[] candidate)
        {
            _CandidateListBox.Items.AddRange(candidate);
        }
    }
}
