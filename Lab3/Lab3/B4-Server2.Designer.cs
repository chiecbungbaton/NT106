namespace Lab3
{
    partial class B4_Server2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            listView1 = new ListView();
            button_Listen = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.ImeMode = ImeMode.NoControl;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(143, 95);
            listView1.Name = "listView1";
            listView1.Size = new Size(416, 343);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.Columns.Add("", 210, HorizontalAlignment.Left);
            listView1.Columns.Add("", 210, HorizontalAlignment.Right);
            // 
            // button_Listen
            // 
            button_Listen.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_Listen.Location = new Point(596, 104);
            button_Listen.Name = "button_Listen";
            button_Listen.Size = new Size(136, 59);
            button_Listen.TabIndex = 2;
            button_Listen.Text = "Listen";
            button_Listen.UseVisualStyleBackColor = true;
            button_Listen.Click += button_Listen_Click;
            // 
            // B4_Server2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Listen);
            Controls.Add(listView1);
            MaximizeBox = false;
            Name = "B4_Server2";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Server 2 bài 4";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button_Listen;
    }
}