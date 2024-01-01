namespace Lab2
{
    partial class Bai5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai5));
            this.compress = new System.Windows.Forms.Button();
            this.decompress = new System.Windows.Forms.Button();
            this.inputdata = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // compress
            // 
            this.compress.BackColor = System.Drawing.Color.Transparent;
            this.compress.FlatAppearance.BorderSize = 0;
            this.compress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.compress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.compress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.compress.Location = new System.Drawing.Point(243, 133);
            this.compress.Name = "compress";
            this.compress.Size = new System.Drawing.Size(122, 47);
            this.compress.TabIndex = 0;
            this.compress.Text = "COMP";
            this.compress.UseVisualStyleBackColor = false;
            this.compress.Click += new System.EventHandler(this.compress_Click);
            // 
            // decompress
            // 
            this.decompress.BackColor = System.Drawing.Color.Transparent;
            this.decompress.FlatAppearance.BorderSize = 0;
            this.decompress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.decompress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.decompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decompress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decompress.Location = new System.Drawing.Point(497, 131);
            this.decompress.Name = "decompress";
            this.decompress.Size = new System.Drawing.Size(117, 50);
            this.decompress.TabIndex = 1;
            this.decompress.Text = "DECOMP";
            this.decompress.UseVisualStyleBackColor = false;
            this.decompress.Click += new System.EventHandler(this.decompress_Click);
            // 
            // inputdata
            // 
            this.inputdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputdata.Location = new System.Drawing.Point(201, 219);
            this.inputdata.Name = "inputdata";
            this.inputdata.Size = new System.Drawing.Size(506, 273);
            this.inputdata.TabIndex = 2;
            this.inputdata.Text = "";
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 546);
            this.Controls.Add(this.inputdata);
            this.Controls.Add(this.decompress);
            this.Controls.Add(this.compress);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);

        }

        #endregion

        private Button compress;
        private Button decompress;
        private RichTextBox inputdata;
    }
}