namespace Lab6
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Bai1 = new System.Windows.Forms.Button();
            this.Bai2 = new System.Windows.Forms.Button();
            this.Bai3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bai1
            // 
            this.Bai1.BackColor = System.Drawing.Color.Transparent;
            this.Bai1.FlatAppearance.BorderSize = 0;
            this.Bai1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Bai1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Bai1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bai1.Location = new System.Drawing.Point(327, 177);
            this.Bai1.Name = "Bai1";
            this.Bai1.Size = new System.Drawing.Size(226, 96);
            this.Bai1.TabIndex = 0;
            this.Bai1.UseVisualStyleBackColor = false;
            this.Bai1.Click += new System.EventHandler(this.Bai1_Click);
            // 
            // Bai2
            // 
            this.Bai2.BackColor = System.Drawing.Color.Transparent;
            this.Bai2.FlatAppearance.BorderSize = 0;
            this.Bai2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Bai2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Bai2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bai2.Location = new System.Drawing.Point(53, 320);
            this.Bai2.Name = "Bai2";
            this.Bai2.Size = new System.Drawing.Size(226, 96);
            this.Bai2.TabIndex = 1;
            this.Bai2.UseVisualStyleBackColor = false;
            this.Bai2.Click += new System.EventHandler(this.Bai2_Click);
            // 
            // Bai3
            // 
            this.Bai3.BackColor = System.Drawing.Color.Transparent;
            this.Bai3.FlatAppearance.BorderSize = 0;
            this.Bai3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Bai3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Bai3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bai3.Location = new System.Drawing.Point(602, 320);
            this.Bai3.Name = "Bai3";
            this.Bai3.Size = new System.Drawing.Size(226, 96);
            this.Bai3.TabIndex = 2;
            this.Bai3.UseVisualStyleBackColor = false;
            this.Bai3.Click += new System.EventHandler(this.Bai3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(873, 580);
            this.Controls.Add(this.Bai3);
            this.Controls.Add(this.Bai2);
            this.Controls.Add(this.Bai1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Bai1;
        private Button Bai2;
        private Button Bai3;
    }
}