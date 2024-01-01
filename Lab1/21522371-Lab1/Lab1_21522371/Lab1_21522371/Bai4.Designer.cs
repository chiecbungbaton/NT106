namespace Lab1_21522371
{
    partial class Bai4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai4));
            this.nhap = new System.Windows.Forms.TextBox();
            this.ketqua = new System.Windows.Forms.TextBox();
            this.doc = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nhap
            // 
            this.nhap.Location = new System.Drawing.Point(349, 211);
            this.nhap.Name = "nhap";
            this.nhap.Size = new System.Drawing.Size(214, 27);
            this.nhap.TabIndex = 0;
            this.nhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nhap.TextChanged += new System.EventHandler(this.nhap_TextChanged);
            // 
            // ketqua
            // 
            this.ketqua.Location = new System.Drawing.Point(202, 295);
            this.ketqua.Name = "ketqua";
            this.ketqua.ReadOnly = true;
            this.ketqua.Size = new System.Drawing.Size(575, 27);
            this.ketqua.TabIndex = 1;
            this.ketqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // doc
            // 
            this.doc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.doc.Location = new System.Drawing.Point(155, 426);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(94, 29);
            this.doc.TabIndex = 2;
            this.doc.Text = "ĐỌC";
            this.doc.UseVisualStyleBackColor = true;
            this.doc.Click += new System.EventHandler(this.doc_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xoa.Location = new System.Drawing.Point(389, 426);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(94, 29);
            this.xoa.TabIndex = 3;
            this.xoa.Text = "XÓA";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click_1);
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thoat.Location = new System.Drawing.Point(615, 426);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(94, 29);
            this.thoat.TabIndex = 4;
            this.thoat.Text = "THOÁT";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click_1);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.doc);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.nhap);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nhap;
        private TextBox ketqua;
        private Button doc;
        private Button xoa;
        private Button thoat;
    }
}