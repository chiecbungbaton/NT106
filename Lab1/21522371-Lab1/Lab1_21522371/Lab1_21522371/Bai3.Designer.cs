namespace Lab1_21522371
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
            this.doc = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.nhap = new System.Windows.Forms.TextBox();
            this.ketqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // doc
            // 
            this.doc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.doc.Location = new System.Drawing.Point(157, 422);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(107, 33);
            this.doc.TabIndex = 0;
            this.doc.Text = "ĐỌC";
            this.doc.UseVisualStyleBackColor = true;
            this.doc.Click += new System.EventHandler(this.doc_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xoa.Location = new System.Drawing.Point(388, 422);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(94, 31);
            this.xoa.TabIndex = 1;
            this.xoa.Text = "XÓA";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thoat.Location = new System.Drawing.Point(611, 421);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(108, 32);
            this.thoat.TabIndex = 2;
            this.thoat.Text = "THOÁT";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // nhap
            // 
            this.nhap.Location = new System.Drawing.Point(406, 212);
            this.nhap.Name = "nhap";
            this.nhap.Size = new System.Drawing.Size(180, 27);
            this.nhap.TabIndex = 3;
            this.nhap.TextChanged += new System.EventHandler(this.nhap_TextChanged);
            // 
            // ketqua
            // 
            this.ketqua.Location = new System.Drawing.Point(206, 294);
            this.ketqua.Name = "ketqua";
            this.ketqua.ReadOnly = true;
            this.ketqua.Size = new System.Drawing.Size(158, 27);
            this.ketqua.TabIndex = 4;
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.nhap);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.doc);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button doc;
        private Button xoa;
        private Button thoat;
        private TextBox nhap;
        private TextBox ketqua;
    }
}