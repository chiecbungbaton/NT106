namespace Lab3
{
    partial class B4_Server1
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
            chat.server.Stop();
            chat.checkConnect = false;
            base.Dispose(disposing);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra xem người dùng có muốn đóng Form hay không
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Nếu không, hủy sự kiện đóng Form
                e.Cancel = true;
            }
            else
            {
                // Nếu có, dừng các hoạt động của chương trình trước khi đóng Form
                // ...
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            button_Listen = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.ImeMode = ImeMode.NoControl;
            listView1.Location = new Point(0, -2);
            listView1.Name = "listView1";
            listView1.Size = new Size(416, 343);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // button_Listen
            // 
            button_Listen.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_Listen.Location = new Point(280, 347);
            button_Listen.Name = "button_Listen";
            button_Listen.Size = new Size(136, 59);
            button_Listen.TabIndex = 1;
            button_Listen.Text = "Listen";
            button_Listen.UseVisualStyleBackColor = true;
            button_Listen.Click += button_Listen_Click;
            // 
            // B4_Server1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.basic;
            ClientSize = new Size(418, 404);
            Controls.Add(button_Listen);
            Controls.Add(listView1);
            MaximizeBox = false;
            Name = "B4_Server1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Server 1 bài 4";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button_Listen;
    }
}