namespace PA4
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
            this.wordList = new System.Windows.Forms.ListBox();
            this.morphBtn = new System.Windows.Forms.Button();
            this.scrabbleBtn = new System.Windows.Forms.Button();
            this.rhymeBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.refillList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordList
            // 
            this.wordList.FormattingEnabled = true;
            this.wordList.Location = new System.Drawing.Point(12, 12);
            this.wordList.Name = "wordList";
            this.wordList.Size = new System.Drawing.Size(287, 420);
            this.wordList.Sorted = true;
            this.wordList.TabIndex = 0;
            this.wordList.Click += new System.EventHandler(this.wordList_Click);
            this.wordList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // morphBtn
            // 
            this.morphBtn.Location = new System.Drawing.Point(319, 180);
            this.morphBtn.Name = "morphBtn";
            this.morphBtn.Size = new System.Drawing.Size(198, 35);
            this.morphBtn.TabIndex = 1;
            this.morphBtn.Text = "Find Morph Words";
            this.morphBtn.UseVisualStyleBackColor = true;
            this.morphBtn.Click += new System.EventHandler(this.morphBtn_Click);
            // 
            // scrabbleBtn
            // 
            this.scrabbleBtn.Location = new System.Drawing.Point(319, 121);
            this.scrabbleBtn.Name = "scrabbleBtn";
            this.scrabbleBtn.Size = new System.Drawing.Size(198, 35);
            this.scrabbleBtn.TabIndex = 1;
            this.scrabbleBtn.Text = "Find Scrabble Words";
            this.scrabbleBtn.UseVisualStyleBackColor = true;
            this.scrabbleBtn.Click += new System.EventHandler(this.scrabbleBtn_Click);
            // 
            // rhymeBtn
            // 
            this.rhymeBtn.Location = new System.Drawing.Point(319, 60);
            this.rhymeBtn.Name = "rhymeBtn";
            this.rhymeBtn.Size = new System.Drawing.Size(198, 35);
            this.rhymeBtn.TabIndex = 1;
            this.rhymeBtn.Text = "Find Rhyming Words";
            this.rhymeBtn.UseVisualStyleBackColor = true;
            this.rhymeBtn.Click += new System.EventHandler(this.rhymeBtn_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(319, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(198, 20);
            this.textBox.TabIndex = 2;
            // 
            // refillList
            // 
            this.refillList.Location = new System.Drawing.Point(319, 241);
            this.refillList.Name = "refillList";
            this.refillList.Size = new System.Drawing.Size(198, 35);
            this.refillList.TabIndex = 1;
            this.refillList.Text = "Refill List";
            this.refillList.UseVisualStyleBackColor = true;
            this.refillList.Click += new System.EventHandler(this.refillList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 448);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.refillList);
            this.Controls.Add(this.rhymeBtn);
            this.Controls.Add(this.scrabbleBtn);
            this.Controls.Add(this.morphBtn);
            this.Controls.Add(this.wordList);
            this.Name = "Form1";
            this.Text = "Word Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox wordList;
        private System.Windows.Forms.Button morphBtn;
        private System.Windows.Forms.Button scrabbleBtn;
        private System.Windows.Forms.Button rhymeBtn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button refillList;
    }
}

