namespace Lab2
{
    partial class Bai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai1));
            this.richtextbox1 = new System.Windows.Forms.RichTextBox();
            this.docfile = new System.Windows.Forms.Button();
            this.ghifile = new System.Windows.Forms.Button();
            this.mo_file = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // richtextbox1
            // 
            this.richtextbox1.BackColor = System.Drawing.Color.FloralWhite;
            this.richtextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtextbox1.ForeColor = System.Drawing.Color.Black;
            this.richtextbox1.Location = new System.Drawing.Point(189, 217);
            this.richtextbox1.Name = "richtextbox1";
            this.richtextbox1.ReadOnly = true;
            this.richtextbox1.Size = new System.Drawing.Size(516, 286);
            this.richtextbox1.TabIndex = 0;
            this.richtextbox1.Text = "";
            this.richtextbox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // docfile
            // 
            this.docfile.BackColor = System.Drawing.Color.Transparent;
            this.docfile.FlatAppearance.BorderSize = 0;
            this.docfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.docfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.docfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.docfile.Location = new System.Drawing.Point(260, 143);
            this.docfile.Name = "docfile";
            this.docfile.Size = new System.Drawing.Size(89, 42);
            this.docfile.TabIndex = 1;
            this.docfile.Text = "READ";
            this.docfile.UseVisualStyleBackColor = false;
            this.docfile.Click += new System.EventHandler(this.docfile_Click);
            // 
            // ghifile
            // 
            this.ghifile.BackColor = System.Drawing.Color.Transparent;
            this.ghifile.FlatAppearance.BorderSize = 0;
            this.ghifile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ghifile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ghifile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ghifile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ghifile.Location = new System.Drawing.Point(511, 146);
            this.ghifile.Name = "ghifile";
            this.ghifile.Size = new System.Drawing.Size(86, 37);
            this.ghifile.TabIndex = 2;
            this.ghifile.Text = "WRITE";
            this.ghifile.UseVisualStyleBackColor = false;
            this.ghifile.Click += new System.EventHandler(this.ghifile_Click);
            // 
            // mo_file
            // 
            this.mo_file.FileName = "openFileDialog";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 550);
            this.Controls.Add(this.ghifile);
            this.Controls.Add(this.docfile);
            this.Controls.Add(this.richtextbox1);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.Load += new System.EventHandler(this.Bai1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richtextbox1;
        private Button docfile;
        private Button ghifile;
        private OpenFileDialog mo_file;
    }
}