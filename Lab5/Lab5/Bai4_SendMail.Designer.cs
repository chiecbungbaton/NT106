namespace Lab5
{
    partial class Bai4_SendMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai4_SendMail));
            this.mailfrom = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.mailto = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.path = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mailfrom
            // 
            this.mailfrom.BackColor = System.Drawing.Color.Ivory;
            this.mailfrom.Location = new System.Drawing.Point(91, 20);
            this.mailfrom.Name = "mailfrom";
            this.mailfrom.ReadOnly = true;
            this.mailfrom.Size = new System.Drawing.Size(330, 27);
            this.mailfrom.TabIndex = 0;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Ivory;
            this.name.Location = new System.Drawing.Point(91, 58);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(330, 27);
            this.name.TabIndex = 1;
            // 
            // subject
            // 
            this.subject.BackColor = System.Drawing.Color.Ivory;
            this.subject.Location = new System.Drawing.Point(91, 129);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(330, 27);
            this.subject.TabIndex = 2;
            // 
            // mailto
            // 
            this.mailto.BackColor = System.Drawing.Color.Ivory;
            this.mailto.Location = new System.Drawing.Point(91, 92);
            this.mailto.Name = "mailto";
            this.mailto.Size = new System.Drawing.Size(330, 27);
            this.mailto.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Honeydew;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.richTextBox1.Location = new System.Drawing.Point(91, 190);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(443, 378);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // path
            // 
            this.path.BackColor = System.Drawing.Color.MintCream;
            this.path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.path.Location = new System.Drawing.Point(91, 581);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(331, 27);
            this.path.TabIndex = 6;
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.Transparent;
            this.browse.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse.Location = new System.Drawing.Point(428, 581);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(106, 32);
            this.browse.TabIndex = 7;
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.Transparent;
            this.send.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Location = new System.Drawing.Point(428, 621);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(106, 44);
            this.send.TabIndex = 8;
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.Transparent;
            this.checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.checkBox.Location = new System.Drawing.Point(97, 166);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(14, 13);
            this.checkBox.TabIndex = 9;
            this.checkBox.UseVisualStyleBackColor = false;
            // 
            // Bai4_SendMail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(566, 678);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.send);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.path);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.mailto);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.name);
            this.Controls.Add(this.mailfrom);
            this.MaximizeBox = false;
            this.Name = "Bai4_SendMail";
            this.Text = "Bai4_SendMail";
            this.Load += new System.EventHandler(this.Bai4_SendMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox mailfrom;
        private TextBox name;
        public TextBox subject;
        public TextBox mailto;
        private RichTextBox richTextBox1;
        private TextBox path;
        private Button browse;
        private Button send;
        private OpenFileDialog openFileDialog;
        private CheckBox checkBox;
    }
}