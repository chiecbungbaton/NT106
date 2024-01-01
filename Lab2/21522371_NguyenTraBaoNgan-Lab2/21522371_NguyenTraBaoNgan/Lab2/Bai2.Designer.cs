namespace Lab2
{
    partial class Bai2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai2));
            this.filename_ = new System.Windows.Forms.TextBox();
            this.size_ = new System.Windows.Forms.TextBox();
            this.url_ = new System.Windows.Forms.TextBox();
            this.linecount_ = new System.Windows.Forms.TextBox();
            this.wordcount_ = new System.Windows.Forms.TextBox();
            this.charactercount_ = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.read = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // filename_
            // 
            this.filename_.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filename_.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filename_.Location = new System.Drawing.Point(207, 211);
            this.filename_.Name = "filename_";
            this.filename_.ReadOnly = true;
            this.filename_.Size = new System.Drawing.Size(198, 34);
            this.filename_.TabIndex = 0;
            this.filename_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // size_
            // 
            this.size_.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.size_.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.size_.Location = new System.Drawing.Point(207, 264);
            this.size_.Name = "size_";
            this.size_.ReadOnly = true;
            this.size_.Size = new System.Drawing.Size(198, 34);
            this.size_.TabIndex = 1;
            this.size_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // url_
            // 
            this.url_.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.url_.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.url_.Location = new System.Drawing.Point(207, 317);
            this.url_.Name = "url_";
            this.url_.ReadOnly = true;
            this.url_.Size = new System.Drawing.Size(198, 34);
            this.url_.TabIndex = 2;
            // 
            // linecount_
            // 
            this.linecount_.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linecount_.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linecount_.Location = new System.Drawing.Point(268, 369);
            this.linecount_.Name = "linecount_";
            this.linecount_.ReadOnly = true;
            this.linecount_.Size = new System.Drawing.Size(136, 34);
            this.linecount_.TabIndex = 3;
            this.linecount_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wordcount_
            // 
            this.wordcount_.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wordcount_.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wordcount_.Location = new System.Drawing.Point(268, 418);
            this.wordcount_.Name = "wordcount_";
            this.wordcount_.ReadOnly = true;
            this.wordcount_.Size = new System.Drawing.Size(136, 34);
            this.wordcount_.TabIndex = 4;
            this.wordcount_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // charactercount_
            // 
            this.charactercount_.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.charactercount_.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.charactercount_.Location = new System.Drawing.Point(268, 467);
            this.charactercount_.Name = "charactercount_";
            this.charactercount_.ReadOnly = true;
            this.charactercount_.Size = new System.Drawing.Size(136, 34);
            this.charactercount_.TabIndex = 5;
            this.charactercount_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Location = new System.Drawing.Point(497, 212);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(309, 292);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            // 
            // read
            // 
            this.read.BackColor = System.Drawing.Color.Transparent;
            this.read.FlatAppearance.BorderSize = 0;
            this.read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.read.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.read.Location = new System.Drawing.Point(259, 135);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(90, 41);
            this.read.TabIndex = 7;
            this.read.Text = "READ";
            this.read.UseVisualStyleBackColor = false;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(509, 132);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(94, 47);
            this.exit.TabIndex = 8;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(912, 541);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.read);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.charactercount_);
            this.Controls.Add(this.wordcount_);
            this.Controls.Add(this.linecount_);
            this.Controls.Add(this.url_);
            this.Controls.Add(this.size_);
            this.Controls.Add(this.filename_);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox filename_;
        private TextBox size_;
        private TextBox url_;
        private TextBox linecount_;
        private TextBox wordcount_;
        private TextBox charactercount_;
        private RichTextBox richTextBox;
        private Button read;
        private Button exit;
        private OpenFileDialog openFileDialog1;
    }
}