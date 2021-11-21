namespace ProgrammingProject3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GetTextButton = new System.Windows.Forms.Button();
            this.WordsFromFileLabel = new System.Windows.Forms.Label();
            this.FirstWordLabel = new System.Windows.Forms.Label();
            this.openFileDialogue = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LastWord = new System.Windows.Forms.Label();
            this.LongestWord = new System.Windows.Forms.Label();
            this.MostVowels = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetTextButton
            // 
            this.GetTextButton.Location = new System.Drawing.Point(9, 423);
            this.GetTextButton.Name = "GetTextButton";
            this.GetTextButton.Size = new System.Drawing.Size(75, 23);
            this.GetTextButton.TabIndex = 1;
            this.GetTextButton.Text = "Get Text";
            this.GetTextButton.UseVisualStyleBackColor = true;
            this.GetTextButton.Click += new System.EventHandler(this.GetTextButton_Click);
            // 
            // WordsFromFileLabel
            // 
            this.WordsFromFileLabel.AutoSize = true;
            this.WordsFromFileLabel.Location = new System.Drawing.Point(9, 245);
            this.WordsFromFileLabel.Name = "WordsFromFileLabel";
            this.WordsFromFileLabel.Size = new System.Drawing.Size(80, 13);
            this.WordsFromFileLabel.TabIndex = 2;
            this.WordsFromFileLabel.Text = "Words from File";
            // 
            // FirstWordLabel
            // 
            this.FirstWordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstWordLabel.Location = new System.Drawing.Point(12, 28);
            this.FirstWordLabel.Name = "FirstWordLabel";
            this.FirstWordLabel.Size = new System.Drawing.Size(80, 13);
            this.FirstWordLabel.TabIndex = 4;
            // 
            // openFileDialogue
            // 
            this.openFileDialogue.Title = "Pick a File Vato";
            this.openFileDialogue.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(90, 423);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(75, 23);
            this.SaveFileButton.TabIndex = 5;
            this.SaveFileButton.Text = "Save File";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 261);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 160);
            this.listBox1.TabIndex = 6;
            // 
            // LastWord
            // 
            this.LastWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastWord.Location = new System.Drawing.Point(12, 53);
            this.LastWord.Name = "LastWord";
            this.LastWord.Size = new System.Drawing.Size(80, 13);
            this.LastWord.TabIndex = 7;
            // 
            // LongestWord
            // 
            this.LongestWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LongestWord.Location = new System.Drawing.Point(12, 78);
            this.LongestWord.Name = "LongestWord";
            this.LongestWord.Size = new System.Drawing.Size(80, 13);
            this.LongestWord.TabIndex = 8;
            // 
            // MostVowels
            // 
            this.MostVowels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MostVowels.Location = new System.Drawing.Point(12, 100);
            this.MostVowels.Name = "MostVowels";
            this.MostVowels.Size = new System.Drawing.Size(172, 133);
            this.MostVowels.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 459);
            this.Controls.Add(this.MostVowels);
            this.Controls.Add(this.LongestWord);
            this.Controls.Add(this.LastWord);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.FirstWordLabel);
            this.Controls.Add(this.WordsFromFileLabel);
            this.Controls.Add(this.GetTextButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dammit Vato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GetTextButton;
        private System.Windows.Forms.Label WordsFromFileLabel;
        private System.Windows.Forms.Label FirstWordLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialogue;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label LastWord;
        private System.Windows.Forms.Label LongestWord;
        private System.Windows.Forms.Label MostVowels;
    }
}

