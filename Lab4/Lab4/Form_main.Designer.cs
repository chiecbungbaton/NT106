namespace Lab4
{
    partial class Form_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            bai1 = new Button();
            bai2 = new Button();
            bai3 = new Button();
            bai4 = new Button();
            bai5 = new Button();
            bai6 = new Button();
            SuspendLayout();
            // 
            // bai1
            // 
            bai1.BackColor = Color.Honeydew;
            bai1.FlatAppearance.BorderSize = 0;
            bai1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bai1.Location = new Point(161, 162);
            bai1.Margin = new Padding(3, 2, 3, 2);
            bai1.Name = "bai1";
            bai1.Size = new Size(130, 35);
            bai1.TabIndex = 0;
            bai1.Text = "TASK 1";
            bai1.UseVisualStyleBackColor = false;
            bai1.Click += bai1_Click;
            // 
            // bai2
            // 
            bai2.BackColor = Color.Honeydew;
            bai2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bai2.Location = new Point(470, 162);
            bai2.Margin = new Padding(3, 2, 3, 2);
            bai2.Name = "bai2";
            bai2.Size = new Size(130, 35);
            bai2.TabIndex = 1;
            bai2.Text = "TASK 2";
            bai2.UseVisualStyleBackColor = false;
            bai2.Click += bai2_Click;
            // 
            // bai3
            // 
            bai3.BackColor = Color.Honeydew;
            bai3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bai3.Location = new Point(161, 242);
            bai3.Margin = new Padding(3, 2, 3, 2);
            bai3.Name = "bai3";
            bai3.Size = new Size(130, 35);
            bai3.TabIndex = 2;
            bai3.Text = "TASK 3";
            bai3.UseVisualStyleBackColor = false;
            bai3.Click += bai3_Click;
            // 
            // bai4
            // 
            bai4.BackColor = Color.Honeydew;
            bai4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bai4.Location = new Point(470, 242);
            bai4.Margin = new Padding(3, 2, 3, 2);
            bai4.Name = "bai4";
            bai4.Size = new Size(130, 35);
            bai4.TabIndex = 3;
            bai4.Text = "TASK 4";
            bai4.UseVisualStyleBackColor = false;
            bai4.Click += bai4_Click;
            // 
            // bai5
            // 
            bai5.BackColor = Color.Honeydew;
            bai5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bai5.Location = new Point(161, 316);
            bai5.Margin = new Padding(3, 2, 3, 2);
            bai5.Name = "bai5";
            bai5.Size = new Size(130, 35);
            bai5.TabIndex = 4;
            bai5.Text = "TASK 5";
            bai5.UseVisualStyleBackColor = false;
            bai5.Click += bai5_Click;
            // 
            // bai6
            // 
            bai6.BackColor = Color.Honeydew;
            bai6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bai6.Location = new Point(470, 316);
            bai6.Margin = new Padding(3, 2, 3, 2);
            bai6.Name = "bai6";
            bai6.Size = new Size(130, 35);
            bai6.TabIndex = 5;
            bai6.Text = "TASK 6";
            bai6.UseVisualStyleBackColor = false;
            bai6.Click += bai6_Click;
            // 
            // Form_main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(744, 474);
            Controls.Add(bai6);
            Controls.Add(bai5);
            Controls.Add(bai4);
            Controls.Add(bai3);
            Controls.Add(bai2);
            Controls.Add(bai1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_main";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bai1;
        private Button bai2;
        private Button bai3;
        private Button bai4;
        private Button bai5;
        private Button bai6;
    }
}