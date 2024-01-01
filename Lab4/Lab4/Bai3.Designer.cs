namespace Lab4
{
    partial class Bai3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai3));
            url = new TextBox();
            path = new TextBox();
            down = new Button();
            richTextBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // url
            // 
            url.BackColor = Color.OldLace;
            url.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            url.Location = new Point(169, 20);
            url.Margin = new Padding(3, 2, 3, 2);
            url.Name = "url";
            url.Size = new Size(305, 27);
            url.TabIndex = 0;
            // 
            // path
            // 
            path.BackColor = Color.OldLace;
            path.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            path.Location = new Point(169, 70);
            path.Margin = new Padding(3, 2, 3, 2);
            path.Name = "path";
            path.Size = new Size(305, 27);
            path.TabIndex = 1;
            // 
            // down
            // 
            down.BackColor = Color.Transparent;
            down.FlatAppearance.BorderSize = 0;
            down.FlatAppearance.MouseDownBackColor = Color.Transparent;
            down.FlatAppearance.MouseOverBackColor = Color.Transparent;
            down.FlatStyle = FlatStyle.Flat;
            down.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            down.ForeColor = Color.Purple;
            down.Location = new Point(528, 42);
            down.Margin = new Padding(3, 2, 3, 2);
            down.Name = "down";
            down.Size = new Size(120, 31);
            down.TabIndex = 2;
            down.Text = "DOWNLOAD";
            down.UseVisualStyleBackColor = false;
            down.Click += down_Click;
            // 
            // richTextBox
            // 
            richTextBox.BackColor = Color.OldLace;
            richTextBox.Location = new Point(50, 115);
            richTextBox.Margin = new Padding(3, 2, 3, 2);
            richTextBox.Name = "richTextBox";
            richTextBox.ReadOnly = true;
            richTextBox.Size = new Size(582, 275);
            richTextBox.TabIndex = 3;
            richTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(63, 28);
            label1.Name = "label1";
            label1.Size = new Size(44, 19);
            label1.TabIndex = 4;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(63, 78);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 5;
            label2.Text = "PATH";
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(699, 401);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox);
            Controls.Add(down);
            Controls.Add(path);
            Controls.Add(url);
            MaximizeBox = false;
            Name = "Bai3";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Bài 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox url;
        private TextBox path;
        private Button down;
        private RichTextBox richTextBox;
        private Label label1;
        private Label label2;
    }
}