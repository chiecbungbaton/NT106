namespace Lab3
{
    partial class B5_Server
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
            disconnect();
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
            listen = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(10, 8);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(448, 216);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // listen
            // 
            listen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listen.Location = new Point(331, 236);
            listen.Margin = new Padding(3, 2, 3, 2);
            listen.Name = "listen";
            listen.Size = new Size(110, 31);
            listen.TabIndex = 1;
            listen.Text = "LISTEN";
            listen.UseVisualStyleBackColor = true;
            listen.Click += listen_Click;
            // 
            // B5_Server
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.basic;
            ClientSize = new Size(466, 278);
            Controls.Add(listen);
            Controls.Add(richTextBox1);
            MaximizeBox = false;
            Name = "B5_Server";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Server bài 5";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button listen;
    }
}