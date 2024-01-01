namespace Lab3
{
    partial class B1_Server
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
            base.Dispose(disposing: true);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B1_Server));
            this.portServer = new System.Windows.Forms.TextBox();
            this.listen = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // portServer
            // 
            this.portServer.Location = new System.Drawing.Point(119, 25);
            this.portServer.Name = "portServer";
            this.portServer.Size = new System.Drawing.Size(124, 27);
            this.portServer.TabIndex = 0;
            this.portServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listen
            // 
            this.listen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listen.Location = new System.Drawing.Point(371, 20);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(93, 36);
            this.listen.TabIndex = 3;
            this.listen.Text = "LISTEN";
            this.listen.UseVisualStyleBackColor = true;
            this.listen.Click += new System.EventHandler(this.listen_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(33, 67);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(453, 208);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port";
            // 
            // B1_Server
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.basic;
            ClientSize = new Size(683, 333);
            Controls.Add(richTextBox1);
            Controls.Add(listen);
            Controls.Add(portServer);
            MaximizeBox = false;
            Name = "B1_Server";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Server bài 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox portServer;
        private Button listen;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}