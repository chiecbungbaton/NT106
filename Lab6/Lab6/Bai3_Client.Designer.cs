namespace Lab6
{
    partial class Bai3_Client
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai3_Client));
            richTextBox_chatRoom = new RichTextBox();
            button_Send = new Button();
            textBox_Name = new TextBox();
            richTextBox_Message = new RichTextBox();
            button_connect = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // richTextBox_chatRoom
            // 
            richTextBox_chatRoom.BackColor = Color.Linen;
            richTextBox_chatRoom.BorderStyle = BorderStyle.None;
            richTextBox_chatRoom.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox_chatRoom.Location = new Point(28, 27);
            richTextBox_chatRoom.Name = "richTextBox_chatRoom";
            richTextBox_chatRoom.Size = new Size(670, 420);
            richTextBox_chatRoom.TabIndex = 1;
            richTextBox_chatRoom.Text = "";
            // 
            // button_Send
            // 
            button_Send.BackColor = Color.Transparent;
            button_Send.Enabled = false;
            button_Send.FlatAppearance.BorderSize = 0;
            button_Send.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_Send.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_Send.FlatStyle = FlatStyle.Flat;
            button_Send.Location = new Point(607, 480);
            button_Send.Name = "button_Send";
            button_Send.Size = new Size(80, 34);
            button_Send.TabIndex = 3;
            button_Send.UseVisualStyleBackColor = false;
            button_Send.Click += button_Send_Click;
            // 
            // textBox_Name
            // 
            textBox_Name.BackColor = Color.Linen;
            textBox_Name.BorderStyle = BorderStyle.None;
            textBox_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Name.Location = new Point(110, 480);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(455, 22);
            textBox_Name.TabIndex = 4;
            // 
            // richTextBox_Message
            // 
            richTextBox_Message.BackColor = Color.Linen;
            richTextBox_Message.BorderStyle = BorderStyle.None;
            richTextBox_Message.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox_Message.Location = new Point(130, 535);
            richTextBox_Message.Name = "richTextBox_Message";
            richTextBox_Message.Size = new Size(436, 62);
            richTextBox_Message.TabIndex = 5;
            richTextBox_Message.Text = "";
            // 
            // button_connect
            // 
            button_connect.BackColor = Color.Transparent;
            button_connect.BorderRadius = 10;
            button_connect.CustomizableEdges = customizableEdges1;
            button_connect.DisabledState.BorderColor = Color.DarkGray;
            button_connect.DisabledState.CustomBorderColor = Color.DarkGray;
            button_connect.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_connect.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_connect.FillColor = Color.SeaShell;
            button_connect.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_connect.ForeColor = Color.IndianRed;
            button_connect.Location = new Point(586, 545);
            button_connect.Name = "button_connect";
            button_connect.ShadowDecoration.CustomizableEdges = customizableEdges2;
            button_connect.Size = new Size(143, 36);
            button_connect.TabIndex = 6;
            button_connect.Text = "Connect";
            button_connect.Click += Connect_Click;
            // 
            // Bai3_Client
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(732, 610);
            Controls.Add(button_connect);
            Controls.Add(richTextBox_Message);
            Controls.Add(textBox_Name);
            Controls.Add(button_Send);
            Controls.Add(richTextBox_chatRoom);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Bai3_Client";
            Text = "Client";
            FormClosed += Bai3_Client_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox_chatRoom;
        private Button button_Send;
        private TextBox textBox_Name;
        private RichTextBox richTextBox_Message;
        private Guna.UI2.WinForms.Guna2Button button_connect;
    }
}