namespace Lab4
{
    partial class Bai2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai2));
            textBox_URL = new TextBox();
            textBox_Data = new TextBox();
            label_URL = new Label();
            label_Data = new Label();
            button_Post = new Button();
            richTextBox_Respone = new RichTextBox();
            SuspendLayout();
            // 
            // textBox_URL
            // 
            textBox_URL.BackColor = Color.SeaShell;
            textBox_URL.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_URL.Location = new Point(123, 16);
            textBox_URL.Name = "textBox_URL";
            textBox_URL.Size = new Size(313, 26);
            textBox_URL.TabIndex = 0;
            textBox_URL.Text = "http://www.contoso.com/PostAccepter.aspx";
            // 
            // textBox_Data
            // 
            textBox_Data.BackColor = Color.SeaShell;
            textBox_Data.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Data.Location = new Point(123, 50);
            textBox_Data.Name = "textBox_Data";
            textBox_Data.Size = new Size(313, 26);
            textBox_Data.TabIndex = 1;
            // 
            // label_URL
            // 
            label_URL.AutoSize = true;
            label_URL.BackColor = Color.Transparent;
            label_URL.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_URL.ForeColor = Color.IndianRed;
            label_URL.Location = new Point(53, 21);
            label_URL.Name = "label_URL";
            label_URL.Size = new Size(40, 21);
            label_URL.TabIndex = 2;
            label_URL.Text = "URL";
            // 
            // label_Data
            // 
            label_Data.AutoSize = true;
            label_Data.BackColor = Color.Transparent;
            label_Data.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Data.ForeColor = Color.IndianRed;
            label_Data.Location = new Point(47, 51);
            label_Data.Name = "label_Data";
            label_Data.Size = new Size(46, 21);
            label_Data.TabIndex = 3;
            label_Data.Text = "Data";
            // 
            // button_Post
            // 
            button_Post.BackColor = Color.Transparent;
            button_Post.FlatAppearance.BorderSize = 0;
            button_Post.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            button_Post.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_Post.FlatStyle = FlatStyle.Flat;
            button_Post.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Post.ForeColor = Color.ForestGreen;
            button_Post.Location = new Point(509, 29);
            button_Post.Name = "button_Post";
            button_Post.Size = new Size(77, 26);
            button_Post.TabIndex = 4;
            button_Post.Text = "POST";
            button_Post.UseVisualStyleBackColor = false;
            button_Post.Click += button_Post_Click;
            // 
            // richTextBox_Respone
            // 
            richTextBox_Respone.BackColor = Color.SeaShell;
            richTextBox_Respone.Location = new Point(39, 90);
            richTextBox_Respone.Name = "richTextBox_Respone";
            richTextBox_Respone.ReadOnly = true;
            richTextBox_Respone.Size = new Size(519, 366);
            richTextBox_Respone.TabIndex = 5;
            richTextBox_Respone.Text = "";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(622, 468);
            Controls.Add(richTextBox_Respone);
            Controls.Add(button_Post);
            Controls.Add(label_Data);
            Controls.Add(label_URL);
            Controls.Add(textBox_Data);
            Controls.Add(textBox_URL);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Bai2";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_URL;
        private TextBox textBox_Data;
        private Label label_URL;
        private Label label_Data;
        private Button button_Post;
        private RichTextBox richTextBox_Respone;
    }
}