namespace Lab3
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            bai5 = new TabPage();
            clientb5 = new Button();
            serverb5 = new Button();
            bai4 = new TabPage();
            clientb4 = new Button();
            server2b4 = new Button();
            server1b4 = new Button();
            bai3 = new TabPage();
            clientb3 = new Button();
            serverb3 = new Button();
            bai2 = new TabPage();
            start = new Button();
            bai1 = new TabPage();
            client = new Button();
            server = new Button();
            Formgocs = new TabControl();
            bai5.SuspendLayout();
            bai4.SuspendLayout();
            bai3.SuspendLayout();
            bai2.SuspendLayout();
            bai1.SuspendLayout();
            Formgocs.SuspendLayout();
            SuspendLayout();
            // 
            // bai5
            // 
            bai5.BackgroundImage = (Image)resources.GetObject("bai5.BackgroundImage");
            bai5.Controls.Add(clientb5);
            bai5.Controls.Add(serverb5);
            bai5.Location = new Point(4, 34);
            bai5.Margin = new Padding(3, 2, 3, 2);
            bai5.Name = "bai5";
            bai5.Padding = new Padding(3, 2, 3, 2);
            bai5.Size = new Size(536, 266);
            bai5.TabIndex = 4;
            bai5.Text = "Bài 5";
            bai5.UseVisualStyleBackColor = true;
            // 
            // clientb5
            // 
            clientb5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clientb5.ForeColor = Color.Purple;
            clientb5.Location = new Point(355, 76);
            clientb5.Margin = new Padding(3, 2, 3, 2);
            clientb5.Name = "clientb5";
            clientb5.Size = new Size(101, 57);
            clientb5.TabIndex = 1;
            clientb5.Text = "CLIENT";
            clientb5.UseVisualStyleBackColor = true;
            clientb5.Click += clientb5_Click;
            // 
            // serverb5
            // 
            serverb5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            serverb5.ForeColor = Color.Purple;
            serverb5.Location = new Point(99, 76);
            serverb5.Margin = new Padding(3, 2, 3, 2);
            serverb5.Name = "serverb5";
            serverb5.Size = new Size(102, 57);
            serverb5.TabIndex = 0;
            serverb5.Text = "SERVER";
            serverb5.UseVisualStyleBackColor = true;
            serverb5.Click += serverb5_Click;
            // 
            // bai4
            // 
            bai4.BackgroundImage = (Image)resources.GetObject("bai4.BackgroundImage");
            bai4.Controls.Add(clientb4);
            bai4.Controls.Add(server2b4);
            bai4.Controls.Add(server1b4);
            bai4.Location = new Point(4, 34);
            bai4.Margin = new Padding(3, 2, 3, 2);
            bai4.Name = "bai4";
            bai4.Padding = new Padding(3, 2, 3, 2);
            bai4.Size = new Size(536, 266);
            bai4.TabIndex = 3;
            bai4.Text = "Bài 4";
            bai4.UseVisualStyleBackColor = true;
            // 
            // clientb4
            // 
            clientb4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clientb4.ForeColor = Color.Purple;
            clientb4.Location = new Point(225, 171);
            clientb4.Margin = new Padding(3, 2, 3, 2);
            clientb4.Name = "clientb4";
            clientb4.Size = new Size(101, 56);
            clientb4.TabIndex = 2;
            clientb4.Text = "CLIENT ";
            clientb4.UseVisualStyleBackColor = true;
            clientb4.Click += clientb4_Click;
            // 
            // server2b4
            // 
            server2b4.Anchor = AnchorStyles.Top;
            server2b4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            server2b4.ForeColor = Color.Purple;
            server2b4.Location = new Point(352, 48);
            server2b4.Margin = new Padding(3, 2, 3, 2);
            server2b4.Name = "server2b4";
            server2b4.Size = new Size(103, 57);
            server2b4.TabIndex = 1;
            server2b4.Text = "SERVER 2";
            server2b4.UseVisualStyleBackColor = true;
            server2b4.Click += server2b4_Click;
            // 
            // server1b4
            // 
            server1b4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            server1b4.ForeColor = Color.Purple;
            server1b4.Location = new Point(98, 48);
            server1b4.Margin = new Padding(3, 2, 3, 2);
            server1b4.Name = "server1b4";
            server1b4.Size = new Size(103, 57);
            server1b4.TabIndex = 0;
            server1b4.Text = "SERVER 1";
            server1b4.UseVisualStyleBackColor = true;
            server1b4.Click += server1b4_Click;
            // 
            // bai3
            // 
            bai3.BackgroundImage = (Image)resources.GetObject("bai3.BackgroundImage");
            bai3.Controls.Add(clientb3);
            bai3.Controls.Add(serverb3);
            bai3.Location = new Point(4, 34);
            bai3.Margin = new Padding(3, 2, 3, 2);
            bai3.Name = "bai3";
            bai3.Padding = new Padding(3, 2, 3, 2);
            bai3.Size = new Size(536, 266);
            bai3.TabIndex = 2;
            bai3.Text = "Bài 3";
            bai3.UseVisualStyleBackColor = true;
            // 
            // clientb3
            // 
            clientb3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clientb3.ForeColor = Color.Purple;
            clientb3.Location = new Point(355, 78);
            clientb3.Margin = new Padding(3, 2, 3, 2);
            clientb3.Name = "clientb3";
            clientb3.Size = new Size(101, 58);
            clientb3.TabIndex = 1;
            clientb3.Text = "CLIENT";
            clientb3.UseVisualStyleBackColor = true;
            clientb3.Click += clientb3_Click;
            // 
            // serverb3
            // 
            serverb3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            serverb3.ForeColor = Color.Purple;
            serverb3.Location = new Point(98, 78);
            serverb3.Margin = new Padding(3, 2, 3, 2);
            serverb3.Name = "serverb3";
            serverb3.Size = new Size(102, 58);
            serverb3.TabIndex = 0;
            serverb3.Text = "SERVER ";
            serverb3.UseVisualStyleBackColor = true;
            serverb3.Click += serverb3_Click;
            // 
            // bai2
            // 
            bai2.BackgroundImage = (Image)resources.GetObject("bai2.BackgroundImage");
            bai2.Controls.Add(start);
            bai2.Location = new Point(4, 34);
            bai2.Margin = new Padding(3, 2, 3, 2);
            bai2.Name = "bai2";
            bai2.Padding = new Padding(3, 2, 3, 2);
            bai2.Size = new Size(536, 266);
            bai2.TabIndex = 1;
            bai2.Text = "Bài 2";
            bai2.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            start.FlatAppearance.BorderColor = Color.Salmon;
            start.FlatAppearance.BorderSize = 0;
            start.FlatStyle = FlatStyle.Flat;
            start.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            start.ForeColor = SystemColors.ButtonHighlight;
            start.Location = new Point(222, 93);
            start.Margin = new Padding(3, 2, 3, 2);
            start.Name = "start";
            start.Size = new Size(106, 42);
            start.TabIndex = 0;
            start.Text = "START";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // bai1
            // 
            this.bai1.BackColor = System.Drawing.Color.Black;
            this.bai1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bai1.BackgroundImage")));
            this.bai1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bai1.Controls.Add(this.client);
            this.bai1.Controls.Add(this.server);
            this.bai1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bai1.Location = new System.Drawing.Point(4, 34);
            this.bai1.Name = "bai1";
            this.bai1.Padding = new System.Windows.Forms.Padding(3);
            this.bai1.Size = new System.Drawing.Size(519, 272);
            this.bai1.TabIndex = 0;
            this.bai1.Text = "Bài 1";
            // 
            // client
            // 
            client.BackColor = Color.Transparent;
            client.FlatAppearance.BorderSize = 0;
            client.FlatAppearance.MouseDownBackColor = Color.Transparent;
            client.FlatAppearance.MouseOverBackColor = Color.Transparent;
            client.FlatStyle = FlatStyle.Flat;
            client.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            client.ForeColor = Color.Purple;
            client.Location = new Point(350, 76);
            client.Margin = new Padding(3, 2, 3, 2);
            client.Name = "client";
            client.Size = new Size(100, 55);
            client.TabIndex = 1;
            client.Text = "CLIENT";
            client.UseVisualStyleBackColor = false;
            client.Click += client_Click_1;
            // 
            // server
            // 
            server.BackColor = Color.Transparent;
            server.FlatAppearance.BorderSize = 0;
            server.FlatAppearance.MouseDownBackColor = Color.Transparent;
            server.FlatAppearance.MouseOverBackColor = Color.Transparent;
            server.FlatStyle = FlatStyle.Flat;
            server.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            server.ForeColor = Color.Purple;
            server.Location = new Point(97, 76);
            server.Margin = new Padding(3, 2, 3, 2);
            server.Name = "server";
            server.Size = new Size(99, 55);
            server.TabIndex = 0;
            server.Text = "SERVER";
            server.UseVisualStyleBackColor = false;
            server.Click += server_Click_1;
            // 
            // Formgocs
            // 
            Formgocs.Controls.Add(bai1);
            Formgocs.Controls.Add(bai2);
            Formgocs.Controls.Add(bai3);
            Formgocs.Controls.Add(bai4);
            Formgocs.Controls.Add(bai5);
            Formgocs.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Formgocs.ImeMode = ImeMode.NoControl;
            Formgocs.ItemSize = new Size(60, 30);
            Formgocs.Location = new Point(10, 8);
            Formgocs.Margin = new Padding(3, 2, 3, 2);
            Formgocs.Name = "Formgocs";
            Formgocs.RightToLeftLayout = true;
            Formgocs.SelectedIndex = 0;
            Formgocs.Size = new Size(544, 304);
            Formgocs.TabIndex = 0;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(551, 306);
            Controls.Add(Formgocs);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form_Main";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Lab 3";
            bai5.ResumeLayout(false);
            bai4.ResumeLayout(false);
            bai3.ResumeLayout(false);
            bai2.ResumeLayout(false);
            bai1.ResumeLayout(false);
            Formgocs.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage bai5;
        private Button clientb5;
        private Button serverb5;
        private TabPage bai4;
        private Button clientb4;
        private Button server2b4;
        private Button server1b4;
        private TabPage bai3;
        private Button clientb3;
        private Button serverb3;
        private TabPage bai2;
        private Button start;
        private TabPage bai1;
        private Button client;
        private Button server;
        public TabControl Formgocs;
    }
}