using System.Text;

namespace Lab3
{
    partial class B3_Client
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
            byte[] datas = Encoding.UTF8.GetBytes("Disconnecting...");
            stream.Write(datas, 0, datas.Length);
            client.Close();
            stream.Close();
            disconnect.Enabled = false;
            send.Enabled = false;
            connect.Enabled = true;
            base.Dispose(disposing: true);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B3_Client));
            this.connect = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.disconnect = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connect.Location = new System.Drawing.Point(25, 23);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(125, 49);
            this.connect.TabIndex = 0;
            this.connect.Text = "CONNECT";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // send
            // 
            this.send.Enabled = false;
            this.send.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.send.Location = new System.Drawing.Point(184, 23);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(143, 49);
            this.send.TabIndex = 1;
            this.send.Text = "SEND";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // disconnect
            // 
            this.disconnect.Enabled = false;
            this.disconnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.disconnect.Location = new System.Drawing.Point(375, 23);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(125, 49);
            this.disconnect.TabIndex = 2;
            this.disconnect.Text = "DISCONNECT";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 93);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(475, 211);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // B3_Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.basic;
            ClientSize = new Size(571, 245);
            Controls.Add(richTextBox1);
            Controls.Add(disconnect);
            Controls.Add(send);
            Controls.Add(connect);
            MaximizeBox = false;
            Name = "B3_Client";
            Text = "Client bài 3";
            ResumeLayout(false);
        }

        #endregion

        private Button connect;
        private Button send;
        private Button disconnect;
        private RichTextBox richTextBox1;
    }
}