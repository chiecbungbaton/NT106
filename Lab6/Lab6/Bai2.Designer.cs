namespace Lab6
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
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.RichTextBox();
            this.encrypted = new System.Windows.Forms.RichTextBox();
            this.decrypted = new System.Windows.Forms.RichTextBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_key
            // 
            this.textBox_key.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_key.ForeColor = System.Drawing.Color.IndianRed;
            this.textBox_key.Location = new System.Drawing.Point(126, 29);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(264, 34);
            this.textBox_key.TabIndex = 0;
            // 
            // data
            // 
            this.data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.data.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.data.Location = new System.Drawing.Point(166, 108);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(528, 137);
            this.data.TabIndex = 4;
            this.data.Text = "";
            // 
            // encrypted
            // 
            this.encrypted.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.encrypted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.encrypted.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.encrypted.Location = new System.Drawing.Point(166, 261);
            this.encrypted.Name = "encrypted";
            this.encrypted.ReadOnly = true;
            this.encrypted.Size = new System.Drawing.Size(528, 135);
            this.encrypted.TabIndex = 5;
            this.encrypted.Text = "";
            // 
            // decrypted
            // 
            this.decrypted.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.decrypted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decrypted.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.decrypted.Location = new System.Drawing.Point(166, 412);
            this.decrypted.Name = "decrypted";
            this.decrypted.ReadOnly = true;
            this.decrypted.Size = new System.Drawing.Size(528, 152);
            this.decrypted.TabIndex = 6;
            this.decrypted.Text = "";
            // 
            // encrypt
            // 
            this.encrypt.BackColor = System.Drawing.Color.Transparent;
            this.encrypt.FlatAppearance.BorderSize = 0;
            this.encrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.encrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encrypt.Location = new System.Drawing.Point(411, 28);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(116, 41);
            this.encrypt.TabIndex = 7;
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
            this.decrypt.Location = new System.Drawing.Point(556, 29);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(112, 39);
            this.decrypt.TabIndex = 8;
            this.decrypt.UseVisualStyleBackColor = false;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // Bai2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(706, 616);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.decrypted);
            this.Controls.Add(this.encrypted);
            this.Controls.Add(this.data);
            this.Controls.Add(this.textBox_key);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Bai2";
            this.Text = "Bài 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_key;
        private RichTextBox data;
        private RichTextBox encrypted;
        private RichTextBox decrypted;
        private Button encrypt;
        private Button decrypt;
    }
}