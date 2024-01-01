namespace Lab1_21522371
{
    partial class Bai5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai5));
            this.loaixe = new System.Windows.Forms.ComboBox();
            this.loaixang = new System.Windows.Forms.ComboBox();
            this.tinh = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.km = new System.Windows.Forms.TextBox();
            this.tien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loaixe
            // 
            this.loaixe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loaixe.FormattingEnabled = true;
            this.loaixe.Items.AddRange(new object[] {
            "Wave Alpha",
            "Sirius",
            "Vision",
            "Lead",
            "Winner",
            "AirBlade",
            "Xe tải"});
            this.loaixe.Location = new System.Drawing.Point(194, 146);
            this.loaixe.Name = "loaixe";
            this.loaixe.Size = new System.Drawing.Size(220, 36);
            this.loaixe.TabIndex = 0;
            this.loaixe.SelectedIndexChanged += new System.EventHandler(this.loaixe_SelectedIndexChanged);
            // 
            // loaixang
            // 
            this.loaixang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loaixang.FormattingEnabled = true;
            this.loaixang.Items.AddRange(new object[] {
            "RON 95 III",
            "E5 RON 92 II",
            "Dầu DO"});
            this.loaixang.Location = new System.Drawing.Point(194, 237);
            this.loaixang.Name = "loaixang";
            this.loaixang.Size = new System.Drawing.Size(220, 36);
            this.loaixang.TabIndex = 1;
            this.loaixang.SelectedIndexChanged += new System.EventHandler(this.loaixang_SelectedIndexChanged);
            // 
            // tinh
            // 
            this.tinh.BackColor = System.Drawing.Color.Transparent;
            this.tinh.FlatAppearance.BorderSize = 0;
            this.tinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tinh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tinh.Location = new System.Drawing.Point(140, 338);
            this.tinh.Name = "tinh";
            this.tinh.Size = new System.Drawing.Size(94, 29);
            this.tinh.TabIndex = 2;
            this.tinh.Text = "TÍNH";
            this.tinh.UseVisualStyleBackColor = false;
            this.tinh.Click += new System.EventHandler(this.tinh_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.Transparent;
            this.xoa.FlatAppearance.BorderSize = 0;
            this.xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xoa.Location = new System.Drawing.Point(358, 338);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(94, 29);
            this.xoa.TabIndex = 3;
            this.xoa.Text = "XÓA";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.thoat.BackColor = System.Drawing.Color.Transparent;
            this.thoat.FlatAppearance.BorderSize = 0;
            this.thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thoat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thoat.Location = new System.Drawing.Point(585, 338);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(94, 29);
            this.thoat.TabIndex = 4;
            this.thoat.Text = "THOÁT";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // km
            // 
            this.km.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.km.Location = new System.Drawing.Point(295, 422);
            this.km.Name = "km";
            this.km.ReadOnly = true;
            this.km.Size = new System.Drawing.Size(119, 34);
            this.km.TabIndex = 5;
            this.km.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tien
            // 
            this.tien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tien.Location = new System.Drawing.Point(599, 422);
            this.tien.Name = "tien";
            this.tien.ReadOnly = true;
            this.tien.Size = new System.Drawing.Size(125, 34);
            this.tien.TabIndex = 6;
            this.tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.tien);
            this.Controls.Add(this.km);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.tinh);
            this.Controls.Add(this.loaixang);
            this.Controls.Add(this.loaixe);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox loaixe;
        private ComboBox loaixang;
        private Button tinh;
        private Button xoa;
        private Button thoat;
        private TextBox km;
        private TextBox tien;
    }
}