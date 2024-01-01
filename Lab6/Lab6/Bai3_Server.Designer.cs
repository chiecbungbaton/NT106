namespace Lab6
{
    partial class Bai3_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai3_Server));
            richTextBox_chatRoom = new RichTextBox();
            Button_Listen = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // richTextBox_chatRoom
            // 
            richTextBox_chatRoom.BackColor = Color.Linen;
            richTextBox_chatRoom.BorderStyle = BorderStyle.None;
            richTextBox_chatRoom.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox_chatRoom.Location = new Point(31, 27);
            richTextBox_chatRoom.Name = "richTextBox_chatRoom";
            richTextBox_chatRoom.Size = new Size(667, 454);
            richTextBox_chatRoom.TabIndex = 0;
            richTextBox_chatRoom.Text = "";
            // 
            // Button_Listen
            // 
            Button_Listen.BackColor = Color.Transparent;
            Button_Listen.BorderColor = Color.Transparent;
            Button_Listen.BorderRadius = 10;
            Button_Listen.CustomizableEdges = customizableEdges1;
            Button_Listen.DisabledState.BorderColor = Color.DarkGray;
            Button_Listen.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_Listen.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_Listen.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_Listen.FillColor = Color.Snow;
            Button_Listen.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Listen.ForeColor = Color.IndianRed;
            Button_Listen.Location = new Point(541, 556);
            Button_Listen.Name = "Button_Listen";
            Button_Listen.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Button_Listen.Size = new Size(144, 50);
            Button_Listen.TabIndex = 2;
            Button_Listen.Text = "Listen";
            Button_Listen.Click += Button_Listen_Click_1;
            // 
            // Bai3_Server
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(728, 609);
            Controls.Add(Button_Listen);
            Controls.Add(richTextBox_chatRoom);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Bai3_Server";
            Text = "Server";
            FormClosed += Bai3_Server_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox_chatRoom;
        private Button button_Listen;
        private Guna.UI2.WinForms.Guna2Button Button_Listen;
    }
}