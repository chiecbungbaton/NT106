namespace Lab5
{
    partial class Bai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai1));
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // from
            // 
            this.from.BackColor = System.Drawing.Color.Honeydew;
            this.from.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.from.Location = new System.Drawing.Point(132, 57);
            this.from.Name = "from";
            this.from.ReadOnly = true;
            this.from.Size = new System.Drawing.Size(418, 30);
            this.from.TabIndex = 0;
            this.from.Text = "baongannguyentra@gmail.com";
            // 
            // to
            // 
            this.to.BackColor = System.Drawing.Color.Honeydew;
            this.to.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.to.Location = new System.Drawing.Point(132, 101);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(418, 30);
            this.to.TabIndex = 1;
            // 
            // subject
            // 
            this.subject.BackColor = System.Drawing.Color.Honeydew;
            this.subject.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subject.Location = new System.Drawing.Point(132, 144);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(651, 30);
            this.subject.TabIndex = 2;
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.Azure;
            this.message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.message.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.message.Location = new System.Drawing.Point(132, 192);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(651, 294);
            this.message.TabIndex = 3;
            this.message.Text = "";
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.Transparent;
            this.send.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Location = new System.Drawing.Point(605, 57);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(135, 55);
            this.send.TabIndex = 4;
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Bai1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(831, 531);
            this.Controls.Add(this.send);
            this.Controls.Add(this.message);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.MaximizeBox = false;
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox from;
        private TextBox to;
        private TextBox subject;
        private RichTextBox message;
        private Button send;
    }
}