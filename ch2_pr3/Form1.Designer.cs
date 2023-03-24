namespace ch2_pr3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.Button();
            this.replace = new System.Windows.Forms.Button();
            this.findNext = new System.Windows.Forms.Button();
            this.replaceAll = new System.Windows.Forms.Button();
            this.chkMatchCase = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 17);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1027, 331);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 442);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find What ?";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(218, 439);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(311, 34);
            this.txtFind.TabIndex = 2;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(218, 502);
            this.txtReplace.Margin = new System.Windows.Forms.Padding(4);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(311, 34);
            this.txtReplace.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 382);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Find and Replace :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 505);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Replace :";
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(586, 420);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(182, 50);
            this.find.TabIndex = 3;
            this.find.Text = "FIND";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // replace
            // 
            this.replace.Location = new System.Drawing.Point(586, 525);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(182, 50);
            this.replace.TabIndex = 3;
            this.replace.Text = "REPLACE";
            this.replace.UseVisualStyleBackColor = true;
            // 
            // findNext
            // 
            this.findNext.Location = new System.Drawing.Point(803, 420);
            this.findNext.Name = "findNext";
            this.findNext.Size = new System.Drawing.Size(182, 50);
            this.findNext.TabIndex = 3;
            this.findNext.Text = "FIND NEXT";
            this.findNext.UseVisualStyleBackColor = true;
            // 
            // replaceAll
            // 
            this.replaceAll.Location = new System.Drawing.Point(803, 525);
            this.replaceAll.Name = "replaceAll";
            this.replaceAll.Size = new System.Drawing.Size(182, 50);
            this.replaceAll.TabIndex = 3;
            this.replaceAll.Text = "REPLACE ALL";
            this.replaceAll.UseVisualStyleBackColor = true;
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(110, 572);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(133, 32);
            this.chkMatchCase.TabIndex = 4;
            this.chkMatchCase.TabStop = true;
            this.chkMatchCase.Text = "Match Case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1072, 708);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.replaceAll);
            this.Controls.Add(this.findNext);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.find);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDITOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private TextBox txtFind;
        private TextBox txtReplace;
        private Label label3;
        private Label label4;
        private Button find;
        private Button replace;
        private Button findNext;
        private Button replaceAll;
        private RadioButton chkMatchCase;
    }
}