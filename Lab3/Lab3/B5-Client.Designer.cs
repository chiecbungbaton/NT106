namespace Lab3
{
    partial class B5_Client
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
            Disconnect();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            name = new TextBox();
            mess = new TextBox();
            label1 = new Label();
            label2 = new Label();
            send = new Button();
            button_Connect = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(10, 9);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(467, 186);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // name
            // 
            name.Location = new Point(91, 208);
            name.Margin = new Padding(3, 2, 3, 2);
            name.Name = "name";
            name.Size = new Size(133, 23);
            name.TabIndex = 1;
            // 
            // mess
            // 
            mess.Location = new Point(91, 245);
            mess.Margin = new Padding(3, 2, 3, 2);
            mess.Name = "mess";
            mess.Size = new Size(302, 23);
            mess.TabIndex = 2;
            mess.KeyDown += mess_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 210);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 244);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Message";
            // 
            // send
            // 
            send.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            send.Location = new Point(399, 238);
            send.Margin = new Padding(3, 2, 3, 2);
            send.Name = "send";
            send.Size = new Size(71, 32);
            send.TabIndex = 5;
            send.Text = "SEND";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // button_Connect
            // 
            button_Connect.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_Connect.Location = new Point(342, 201);
            button_Connect.Margin = new Padding(3, 2, 3, 2);
            button_Connect.Name = "button_Connect";
            button_Connect.Size = new Size(128, 32);
            button_Connect.TabIndex = 6;
            button_Connect.Text = "Connect";
            button_Connect.UseVisualStyleBackColor = true;
            button_Connect.Click += button_Connect_Click;
            // 
            // B5_Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.basic;
            ClientSize = new Size(482, 275);
            Controls.Add(button_Connect);
            Controls.Add(send);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mess);
            Controls.Add(name);
            Controls.Add(richTextBox1);
            MaximizeBox = false;
            Name = "B5_Client";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Client bài 5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox name;
        private TextBox mess;
        private Label label1;
        private Label label2;
        private Button send;
        private Button button_Connect;
    }
}