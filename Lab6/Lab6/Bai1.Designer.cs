namespace Lab6
{
    partial class Bai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai1));
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.textBox_shift = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.RichTextBox();
            this.encrypted = new System.Windows.Forms.RichTextBox();
            this.decrypted = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // encrypt
            // 
            this.encrypt.BackColor = System.Drawing.Color.Transparent;
            this.encrypt.FlatAppearance.BorderSize = 0;
            this.encrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.encrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encrypt.Location = new System.Drawing.Point(368, 27);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(116, 41);
            this.encrypt.TabIndex = 0;
            this.encrypt.UseVisualStyleBackColor = false;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.BackColor = System.Drawing.Color.Transparent;
            this.decrypt.FlatAppearance.BorderSize = 0;
            this.decrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.decrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrypt.Location = new System.Drawing.Point(558, 30);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(112, 39);
            this.decrypt.TabIndex = 1;
            this.decrypt.UseVisualStyleBackColor = false;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // textBox_shift
            // 
            this.textBox_shift.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_shift.ForeColor = System.Drawing.Color.IndianRed;
            this.textBox_shift.Location = new System.Drawing.Point(162, 30);
            this.textBox_shift.Name = "textBox_shift";
            this.textBox_shift.Size = new System.Drawing.Size(57, 34);
            this.textBox_shift.TabIndex = 2;
            this.textBox_shift.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // data
            // 
            this.data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.data.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.data.Location = new System.Drawing.Point(160, 105);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(528, 137);
            this.data.TabIndex = 3;
            this.data.Text = "";
            // 
            // encrypted
            // 
            this.encrypted.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.encrypted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.encrypted.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.encrypted.Location = new System.Drawing.Point(160, 260);
            this.encrypted.Name = "encrypted";
            this.encrypted.ReadOnly = true;
            this.encrypted.Size = new System.Drawing.Size(528, 135);
            this.encrypted.TabIndex = 4;
            this.encrypted.Text = "";
            // 
            // decrypted
            // 
            this.decrypted.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.decrypted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decrypted.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.decrypted.Location = new System.Drawing.Point(160, 411);
            this.decrypted.Name = "decrypted";
            this.decrypted.ReadOnly = true;
            this.decrypted.Size = new System.Drawing.Size(528, 152);
            this.decrypted.TabIndex = 5;
            this.decrypted.Text = "";
            // 
            // Bai1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(718, 612);
            this.Controls.Add(this.decrypted);
            this.Controls.Add(this.encrypted);
            this.Controls.Add(this.data);
            this.Controls.Add(this.textBox_shift);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.MaximizeBox = false;
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button encrypt;
        private Button decrypt;
        private TextBox textBox_shift;
        private RichTextBox data;
        private RichTextBox encrypted;
        private RichTextBox decrypted;
    }
}