namespace Lab3
{
    partial class B4_Client
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
            try
            {
                _isconnect = false;
                ChatTCP_Server.send("User " + textBox_UserName.Text + " đã ngắt kết nối", Client.GetStream());
                _isconnect = false;
                Client.Close();
            }
            catch { }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_Send = new Button();
            button_Connect = new Button();
            textBox_Send = new TextBox();
            richTextBox_Message = new RichTextBox();
            textBox_UserName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_Send
            // 
            button_Send.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_Send.Location = new Point(593, 372);
            button_Send.Name = "button_Send";
            button_Send.Size = new Size(98, 36);
            button_Send.TabIndex = 0;
            button_Send.Text = "Send";
            button_Send.UseVisualStyleBackColor = true;
            button_Send.Click += button_Send_Click;
            // 
            // button_Connect
            // 
            button_Connect.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_Connect.Location = new Point(625, 96);
            button_Connect.Name = "button_Connect";
            button_Connect.Size = new Size(168, 36);
            button_Connect.TabIndex = 1;
            button_Connect.Text = "Connect";
            button_Connect.UseVisualStyleBackColor = true;
            button_Connect.Click += button_Connect_Click;
            // 
            // textBox_Send
            // 
            textBox_Send.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Send.Location = new Point(147, 379);
            textBox_Send.Name = "textBox_Send";
            textBox_Send.Size = new Size(440, 26);
            textBox_Send.TabIndex = 2;
            textBox_Send.KeyDown += textBox_Send_KeyDown;
            // 
            // richTextBox_Message
            // 
            richTextBox_Message.Location = new Point(147, 96);
            richTextBox_Message.Name = "richTextBox_Message";
            richTextBox_Message.Size = new Size(472, 267);
            richTextBox_Message.TabIndex = 3;
            richTextBox_Message.Text = "";
            // 
            // textBox_UserName
            // 
            textBox_UserName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_UserName.Location = new Point(147, 51);
            textBox_UserName.Name = "textBox_UserName";
            textBox_UserName.Size = new Size(369, 26);
            textBox_UserName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 51);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 5;
            label1.Text = "User name";
            // 
            // B4_Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.basic;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox_UserName);
            Controls.Add(richTextBox_Message);
            Controls.Add(textBox_Send);
            Controls.Add(button_Connect);
            Controls.Add(button_Send);
            MaximizeBox = false;
            Name = "B4_Client";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Client bài 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Send;
        private Button button_Connect;
        private TextBox textBox_Send;
        private RichTextBox richTextBox_Message;
        private TextBox textBox_UserName;
        private Label label1;
    }
}