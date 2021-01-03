
namespace documentSearcher.UI
{
    partial class CandidateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._CandidateListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _CandidateListBox
            // 
            this._CandidateListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._CandidateListBox.FormattingEnabled = true;
            this._CandidateListBox.ItemHeight = 18;
            this._CandidateListBox.Location = new System.Drawing.Point(0, 0);
            this._CandidateListBox.Name = "_CandidateListBox";
            this._CandidateListBox.Size = new System.Drawing.Size(800, 450);
            this._CandidateListBox.TabIndex = 1;
            // 
            // CandidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._CandidateListBox);
            this.Name = "CandidateForm";
            this.Text = "CandidateForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox _CandidateListBox;
    }
}