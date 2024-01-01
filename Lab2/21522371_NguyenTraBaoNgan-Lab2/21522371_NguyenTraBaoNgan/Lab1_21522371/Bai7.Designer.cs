namespace Lab1_21522371
{
    partial class Bai7
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
        ///  private Label labelAddress;
        private Label labelSubnetMask;
        private Label labelNumSubnets;
        private TextBox textBoxAddress;
        private TextBox textBoxSubnetMask;
        private TextBox textBoxNumSubnets;
        private Button buttonCalculate;
        private DataGridView dataGridViewSubnets;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai7));
            this.bangchiasubnet = new System.Windows.Forms.DataGridView();
            this.nhapip = new System.Windows.Forms.TextBox();
            this.chia = new System.Windows.Forms.Button();
            this.somangcon = new System.Windows.Forms.TextBox();
            this.subnet = new System.Windows.Forms.TextBox();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bangchiasubnet)).BeginInit();
            this.SuspendLayout();
            // 
            // bangchiasubnet
            // 
            this.bangchiasubnet.AllowUserToOrderColumns = true;
            this.bangchiasubnet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bangchiasubnet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangchiasubnet.Location = new System.Drawing.Point(161, 400);
            this.bangchiasubnet.Name = "bangchiasubnet";
            this.bangchiasubnet.ReadOnly = true;
            this.bangchiasubnet.RowHeadersWidth = 51;
            this.bangchiasubnet.RowTemplate.Height = 29;
            this.bangchiasubnet.Size = new System.Drawing.Size(607, 250);
            this.bangchiasubnet.TabIndex = 0;
            // 
            // nhapip
            // 
            this.nhapip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nhapip.Location = new System.Drawing.Point(273, 160);
            this.nhapip.Name = "nhapip";
            this.nhapip.Size = new System.Drawing.Size(193, 34);
            this.nhapip.TabIndex = 1;
            this.nhapip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chia
            // 
            this.chia.BackColor = System.Drawing.Color.Transparent;
            this.chia.FlatAppearance.BorderSize = 0;
            this.chia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chia.Location = new System.Drawing.Point(236, 294);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(94, 33);
            this.chia.TabIndex = 3;
            this.chia.Text = "CHIA IP";
            this.chia.UseVisualStyleBackColor = false;
            this.chia.Click += new System.EventHandler(this.chia_Click);
            // 
            // somangcon
            // 
            this.somangcon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.somangcon.Location = new System.Drawing.Point(443, 224);
            this.somangcon.Name = "somangcon";
            this.somangcon.Size = new System.Drawing.Size(101, 34);
            this.somangcon.TabIndex = 4;
            this.somangcon.TextChanged += new System.EventHandler(this.somangcon_TextChanged);
            // 
            // subnet
            // 
            this.subnet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subnet.Location = new System.Drawing.Point(678, 160);
            this.subnet.Name = "subnet";
            this.subnet.Size = new System.Drawing.Size(207, 34);
            this.subnet.TabIndex = 5;
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.Transparent;
            this.xoa.FlatAppearance.BorderSize = 0;
            this.xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xoa.Location = new System.Drawing.Point(441, 295);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(103, 34);
            this.xoa.TabIndex = 6;
            this.xoa.Text = "XÓA";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.Transparent;
            this.thoat.FlatAppearance.BorderSize = 0;
            this.thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thoat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thoat.Location = new System.Drawing.Point(651, 293);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(101, 37);
            this.thoat.TabIndex = 7;
            this.thoat.Text = "THOÁT";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(956, 691);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.subnet);
            this.Controls.Add(this.somangcon);
            this.Controls.Add(this.chia);
            this.Controls.Add(this.nhapip);
            this.Controls.Add(this.bangchiasubnet);
            this.Name = "Bai7";
            this.Text = "Bai7";
            ((System.ComponentModel.ISupportInitialize)(this.bangchiasubnet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private DataGridView bangchiasubnet;
        private TextBox nhapip;
        private Button chia;
        private TextBox somangcon;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn network;
        private DataGridViewTextBoxColumn firstaddress;
        private DataGridViewTextBoxColumn lastaddress;
        private DataGridViewTextBoxColumn broadcast;
        private TextBox subnet;
        private Button xoa;
        private Button thoat;
    }
}