namespace Lab4
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
            link = new TextBox();
            getlink = new Button();
            richtextbox = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // link
            // 
            link.BackColor = Color.Cornsilk;
            link.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            link.Location = new Point(177, 29);
            link.Margin = new Padding(3, 2, 3, 2);
            link.Name = "link";
            link.Size = new Size(345, 29);
            link.TabIndex = 0;
            // 
            // getlink
            // 
            getlink.BackColor = Color.Transparent;
            getlink.FlatAppearance.BorderSize = 0;
            getlink.FlatAppearance.MouseDownBackColor = Color.Transparent;
            getlink.FlatAppearance.MouseOverBackColor = Color.Transparent;
            getlink.FlatStyle = FlatStyle.Flat;
            getlink.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            getlink.ForeColor = SystemColors.ControlLightLight;
            getlink.Location = new Point(571, 26);
            getlink.Margin = new Padding(3, 2, 3, 2);
            getlink.Name = "getlink";
            getlink.Size = new Size(75, 32);
            getlink.TabIndex = 1;
            getlink.Text = "GET";
            getlink.UseVisualStyleBackColor = false;
            getlink.Click += getlink_Click;
            // 
            // richtextbox
            // 
            richtextbox.BackColor = Color.Cornsilk;
            richtextbox.Location = new Point(90, 78);
            richtextbox.Margin = new Padding(3, 2, 3, 2);
            richtextbox.Name = "richtextbox";
            richtextbox.ReadOnly = true;
            richtextbox.Size = new Size(567, 300);
            richtextbox.TabIndex = 2;
            richtextbox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(49, 32);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 3;
            label1.Text = "URL";
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(697, 407);
            Controls.Add(label1);
            Controls.Add(richtextbox);
            Controls.Add(getlink);
            Controls.Add(link);
            MaximizeBox = false;
            Name = "Bai1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Bài 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox link;
        private Button getlink;
        private RichTextBox richtextbox;
        private Label label1;
    }
}