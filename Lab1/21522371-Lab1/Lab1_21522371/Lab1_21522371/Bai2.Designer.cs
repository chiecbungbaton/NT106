namespace Lab1_21522371
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
            this.max = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.xoa = new System.Windows.Forms.Button();
            this.so1 = new System.Windows.Forms.TextBox();
            this.so2 = new System.Windows.Forms.TextBox();
            this.so3 = new System.Windows.Forms.TextBox();
            this.tim = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(630, 219);
            this.max.Name = "max";
            this.max.ReadOnly = true;
            this.max.Size = new System.Drawing.Size(125, 27);
            this.max.TabIndex = 3;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(630, 286);
            this.min.Name = "min";
            this.min.ReadOnly = true;
            this.min.Size = new System.Drawing.Size(125, 27);
            this.min.TabIndex = 4;
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xoa.Location = new System.Drawing.Point(386, 426);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(94, 29);
            this.xoa.TabIndex = 6;
            this.xoa.Text = " XÓA";
            this.xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // so1
            // 
            this.so1.Location = new System.Drawing.Point(243, 191);
            this.so1.Name = "so1";
            this.so1.Size = new System.Drawing.Size(125, 27);
            this.so1.TabIndex = 7;
            // 
            // so2
            // 
            this.so2.Location = new System.Drawing.Point(243, 259);
            this.so2.Name = "so2";
            this.so2.Size = new System.Drawing.Size(125, 27);
            this.so2.TabIndex = 8;
            // 
            // so3
            // 
            this.so3.Location = new System.Drawing.Point(243, 325);
            this.so3.Name = "so3";
            this.so3.Size = new System.Drawing.Size(125, 27);
            this.so3.TabIndex = 9;
            // 
            // tim
            // 
            this.tim.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tim.Location = new System.Drawing.Point(149, 426);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(94, 29);
            this.tim.TabIndex = 10;
            this.tim.Text = "TÌM";
            this.tim.UseVisualStyleBackColor = true;
            this.tim.Click += new System.EventHandler(this.tim_CLick);
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thoat.Location = new System.Drawing.Point(614, 426);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(94, 29);
            this.thoat.TabIndex = 11;
            this.thoat.Text = "THOÁT";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(811, 481);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.so3);
            this.Controls.Add(this.so2);
            this.Controls.Add(this.so1);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button tim;
        private Button thoat;
        private Button xoa;
        private TextBox max;
        private TextBox min;
        private TextBox so1;
        private TextBox so2;
        private TextBox so3;
        
    }
}