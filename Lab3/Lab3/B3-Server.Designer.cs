namespace Lab3
{
    partial class B3_Server
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
            server.Stop();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox = new RichTextBox();
            listen = new Button();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.BackColor = SystemColors.ButtonHighlight;
            richTextBox.Location = new Point(29, 83);
            richTextBox.Name = "richTextBox";
            richTextBox.ReadOnly = true;
            richTextBox.Size = new Size(485, 270);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            // 
            // listen
            // 
            listen.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            listen.Location = new Point(382, 21);
            listen.Name = "listen";
            listen.Size = new Size(132, 43);
            listen.TabIndex = 1;
            listen.Text = "LISTEN";
            listen.UseVisualStyleBackColor = true;
            listen.Click += listen_Click;
            // 
            // B3_Server
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.basic2;
            ClientSize = new Size(547, 410);
            Controls.Add(listen);
            Controls.Add(richTextBox);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "B3_Server";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Server bài 3";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox;
        private Button listen;
    }
}