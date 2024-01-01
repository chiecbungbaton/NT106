namespace Lab4
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
            button_get = new Button();
            panel1 = new Panel();
            next = new Button();
            back = new Button();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // button_get
            // 
            button_get.BackColor = Color.Transparent;
            button_get.FlatAppearance.BorderSize = 0;
            button_get.FlatAppearance.MouseDownBackColor = Color.AliceBlue;
            button_get.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button_get.FlatStyle = FlatStyle.Flat;
            button_get.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_get.ForeColor = SystemColors.ButtonHighlight;
            button_get.Location = new Point(746, 39);
            button_get.Margin = new Padding(3, 2, 3, 2);
            button_get.Name = "button_get";
            button_get.Size = new Size(105, 30);
            button_get.TabIndex = 2;
            button_get.Text = "GET";
            button_get.UseVisualStyleBackColor = false;
            button_get.Click += button_get_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.SeaShell;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(58, 97);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 349);
            panel1.TabIndex = 3;
            // 
            // next
            // 
            next.BackColor = Color.Transparent;
            next.Enabled = false;
            next.FlatAppearance.BorderSize = 0;
            next.FlatAppearance.MouseDownBackColor = Color.Transparent;
            next.FlatAppearance.MouseOverBackColor = Color.Transparent;
            next.FlatStyle = FlatStyle.Flat;
            next.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            next.ForeColor = SystemColors.ButtonHighlight;
            next.Location = new Point(669, 42);
            next.Margin = new Padding(3, 2, 3, 2);
            next.Name = "next";
            next.Size = new Size(28, 28);
            next.TabIndex = 4;
            next.Text = ">";
            next.UseVisualStyleBackColor = false;
            next.Click += next_Click;
            // 
            // back
            // 
            back.BackColor = Color.Transparent;
            back.Enabled = false;
            back.FlatAppearance.BorderSize = 0;
            back.FlatAppearance.MouseDownBackColor = Color.Transparent;
            back.FlatAppearance.MouseOverBackColor = Color.Transparent;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            back.ForeColor = SystemColors.ButtonHighlight;
            back.Location = new Point(560, 42);
            back.Margin = new Padding(3, 2, 3, 2);
            back.Name = "back";
            back.Size = new Size(28, 28);
            back.TabIndex = 5;
            back.Text = "<";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(606, 46);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 6;
            label1.Text = "PAGE";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Linen;
            progressBar1.ForeColor = Color.PeachPuff;
            progressBar1.Location = new Point(67, 460);
            progressBar1.Margin = new Padding(3, 2, 3, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(121, 20);
            progressBar1.TabIndex = 7;
            // 
            // Bai5
            // 
            AccessibleRole = AccessibleRole.ScrollBar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(879, 491);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(back);
            Controls.Add(next);
            Controls.Add(panel1);
            Controls.Add(button_get);
            MaximizeBox = false;
            Name = "Bai5";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Bài 5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_get;
        private Panel panel1;
        private Button next;
        private Button back;
        private Label label1;
        private ProgressBar progressBar1;
    }
}