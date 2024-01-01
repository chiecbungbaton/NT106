namespace Lab5
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bai1 = new System.Windows.Forms.Button();
            this.bai2 = new System.Windows.Forms.Button();
            this.bai4 = new System.Windows.Forms.Button();
            this.bai3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bai1
            // 
            this.bai1.BackColor = System.Drawing.Color.Transparent;
            this.bai1.FlatAppearance.BorderSize = 0;
            this.bai1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bai1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bai1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bai1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bai1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bai1.Location = new System.Drawing.Point(195, 196);
            this.bai1.Name = "bai1";
            this.bai1.Size = new System.Drawing.Size(138, 67);
            this.bai1.TabIndex = 0;
            this.bai1.Text = "TASK 1";
            this.bai1.UseVisualStyleBackColor = false;
            this.bai1.Click += new System.EventHandler(this.bai1_Click);
            // 
            // bai2
            // 
            this.bai2.BackColor = System.Drawing.Color.Transparent;
            this.bai2.FlatAppearance.BorderSize = 0;
            this.bai2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bai2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bai2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bai2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bai2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bai2.Location = new System.Drawing.Point(505, 196);
            this.bai2.Name = "bai2";
            this.bai2.Size = new System.Drawing.Size(140, 67);
            this.bai2.TabIndex = 1;
            this.bai2.Text = "TASK 2 ";
            this.bai2.UseVisualStyleBackColor = false;
            this.bai2.Click += new System.EventHandler(this.bai2_Click);
            // 
            // bai4
            // 
            this.bai4.BackColor = System.Drawing.Color.Transparent;
            this.bai4.FlatAppearance.BorderSize = 0;
            this.bai4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bai4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bai4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bai4.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bai4.ForeColor = System.Drawing.Color.Transparent;
            this.bai4.Location = new System.Drawing.Point(506, 342);
            this.bai4.Name = "bai4";
            this.bai4.Size = new System.Drawing.Size(140, 64);
            this.bai4.TabIndex = 3;
            this.bai4.Text = "TASK 4";
            this.bai4.UseVisualStyleBackColor = false;
            this.bai4.Click += new System.EventHandler(this.bai4_Click);
            // 
            // bai3
            // 
            this.bai3.BackColor = System.Drawing.Color.Transparent;
            this.bai3.FlatAppearance.BorderSize = 0;
            this.bai3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bai3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bai3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bai3.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bai3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bai3.Location = new System.Drawing.Point(190, 343);
            this.bai3.Name = "bai3";
            this.bai3.Size = new System.Drawing.Size(138, 58);
            this.bai3.TabIndex = 4;
            this.bai3.Text = "TASK 3";
            this.bai3.UseVisualStyleBackColor = false;
            this.bai3.Click += new System.EventHandler(this.bai3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(836, 536);
            this.Controls.Add(this.bai3);
            this.Controls.Add(this.bai4);
            this.Controls.Add(this.bai2);
            this.Controls.Add(this.bai1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bai1;
        private Button bai2;
        private Button bai4;
        private Button bai3;
    }
}