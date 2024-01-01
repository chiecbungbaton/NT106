namespace Lab2
{
    partial class Bai3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai3));
            this.read = new System.Windows.Forms.Button();
            this.write = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // read
            // 
            this.read.BackColor = System.Drawing.Color.Transparent;
            this.read.FlatAppearance.BorderSize = 0;
            this.read.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.read.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.read.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.read.Location = new System.Drawing.Point(265, 133);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(82, 46);
            this.read.TabIndex = 0;
            this.read.Text = "READ";
            this.read.UseVisualStyleBackColor = false;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // write
            // 
            this.write.BackColor = System.Drawing.Color.Transparent;
            this.write.FlatAppearance.BorderSize = 0;
            this.write.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.write.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.write.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.write.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.write.Location = new System.Drawing.Point(507, 136);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(92, 41);
            this.write.TabIndex = 1;
            this.write.Text = "WRITE";
            this.write.UseVisualStyleBackColor = false;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(229, 217);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(431, 285);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(887, 545);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.write);
            this.Controls.Add(this.read);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);

        }

        #endregion

        private Button read;
        private Button write;
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog;
    }
}