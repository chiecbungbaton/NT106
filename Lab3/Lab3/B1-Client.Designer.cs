namespace Lab3
{
    partial class B1_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B1_Client));
            this.ipAdd = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.portClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipAdd
            // 
            this.ipAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ipAdd.Location = new System.Drawing.Point(40, 52);
            this.ipAdd.Name = "ipAdd";
            this.ipAdd.ReadOnly = true;
            this.ipAdd.Size = new System.Drawing.Size(185, 27);
            this.ipAdd.TabIndex = 0;
            this.ipAdd.Text = "127.0.0.1";
            this.ipAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(22, 97);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(479, 189);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.send.Location = new System.Drawing.Point(418, 44);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(83, 35);
            this.send.TabIndex = 2;
            this.send.Text = "SEND";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // portClient
            // 
            this.portClient.BackColor = System.Drawing.SystemColors.HighlightText;
            this.portClient.Location = new System.Drawing.Point(276, 52);
            this.portClient.Name = "portClient";
            this.portClient.Size = new System.Drawing.Size(118, 27);
            this.portClient.TabIndex = 3;
            this.portClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(276, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // B1_Client
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.basic;
            ClientSize = new Size(647, 368);
            Controls.Add(portClient);
            Controls.Add(send);
            Controls.Add(richTextBox);
            Controls.Add(ipAdd);
            MinimizeBox = false;
            Name = "B1_Client";
            Text = "Client bài 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox ipAdd;
        private RichTextBox richTextBox;
        private Button send;
        private TextBox portClient;
        private Label label1;
        private Label label2;
    }
}