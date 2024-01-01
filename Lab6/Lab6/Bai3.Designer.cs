namespace Lab6
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
            server = new Button();
            client = new Button();
            SuspendLayout();
            // 
            // server
            // 
            server.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            server.BackColor = Color.Transparent;
            server.FlatAppearance.BorderSize = 0;
            server.FlatAppearance.MouseDownBackColor = Color.Transparent;
            server.FlatAppearance.MouseOverBackColor = Color.Transparent;
            server.FlatStyle = FlatStyle.Flat;
            server.Location = new Point(84, 144);
            server.Margin = new Padding(3, 2, 3, 2);
            server.Name = "server";
            server.Size = new Size(74, 40);
            server.TabIndex = 0;
            server.UseVisualStyleBackColor = false;
            server.Click += server_Click;
            // 
            // client
            // 
            client.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            client.BackColor = Color.Transparent;
            client.FlatAppearance.BorderSize = 0;
            client.FlatAppearance.MouseDownBackColor = Color.Transparent;
            client.FlatAppearance.MouseOverBackColor = Color.Transparent;
            client.FlatStyle = FlatStyle.Flat;
            client.Location = new Point(266, 144);
            client.Margin = new Padding(3, 2, 3, 2);
            client.Name = "client";
            client.Size = new Size(74, 40);
            client.TabIndex = 1;
            client.UseVisualStyleBackColor = false;
            client.Click += client_Click;
            // 
            // Bai3
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(439, 310);
            Controls.Add(client);
            Controls.Add(server);
            MaximizeBox = false;
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
        }

        #endregion

        private Button server;
        private Button client;
    }
}