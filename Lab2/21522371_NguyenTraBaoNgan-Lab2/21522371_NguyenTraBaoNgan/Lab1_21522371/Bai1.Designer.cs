namespace Lab1_21522371
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.so1 = new System.Windows.Forms.TextBox();
            this.so2 = new System.Windows.Forms.TextBox();
            this.tong = new System.Windows.Forms.TextBox();
            this.nuttong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.pictureBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 512);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // so1
            // 
            this.so1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.so1.Location = new System.Drawing.Point(287, 181);
            this.so1.Name = "so1";
            this.so1.Size = new System.Drawing.Size(214, 38);
            this.so1.TabIndex = 1;
            this.so1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // so2
            // 
            this.so2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.so2.Location = new System.Drawing.Point(287, 257);
            this.so2.Name = "so2";
            this.so2.Size = new System.Drawing.Size(214, 38);
            this.so2.TabIndex = 2;
            this.so2.TextChanged += new System.EventHandler(this.so2_TextChanged);
            // 
            // tong
            // 
            this.tong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tong.Location = new System.Drawing.Point(287, 332);
            this.tong.Name = "tong";
            this.tong.ReadOnly = true;
            this.tong.Size = new System.Drawing.Size(214, 38);
            this.tong.TabIndex = 3;
            this.tong.TextChanged += new System.EventHandler(this.tong_TextChanged);
            // 
            // nuttong
            // 
            this.nuttong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nuttong.ForeColor = System.Drawing.SystemColors.Info;
            this.nuttong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuttong.Location = new System.Drawing.Point(541, 340);
            this.nuttong.Name = "nuttong";
            this.nuttong.Size = new System.Drawing.Size(94, 29);
            this.nuttong.TabIndex = 4;
            this.nuttong.Text = "TÍNH";
            this.nuttong.UseVisualStyleBackColor = false;
            this.nuttong.Click += new System.EventHandler(this.nuttong_CLick);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nuttong);
            this.Controls.Add(this.tong);
            this.Controls.Add(this.so2);
            this.Controls.Add(this.so1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Bai1";
            this.Text = "Bai1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox so1;
        private TextBox so2;
        private TextBox tong;
        private Button nuttong;
    }
}