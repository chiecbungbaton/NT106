namespace Lab4
{
    partial class Bai4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai4));
            webView2_view = new Microsoft.Web.WebView2.WinForms.WebView2();
            textBox_URL = new TextBox();
            button_Search = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)webView2_view).BeginInit();
            SuspendLayout();
            // 
            // webView2_view
            // 
            webView2_view.AllowExternalDrop = true;
            webView2_view.CreationProperties = null;
            webView2_view.DefaultBackgroundColor = Color.White;
            webView2_view.Location = new Point(15, 80);
            webView2_view.Name = "webView2_view";
            webView2_view.Size = new Size(931, 511);
            webView2_view.TabIndex = 0;
            webView2_view.ZoomFactor = 1D;
            // 
            // textBox_URL
            // 
            textBox_URL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_URL.Location = new Point(52, 21);
            textBox_URL.Name = "textBox_URL";
            textBox_URL.Size = new Size(424, 29);
            textBox_URL.TabIndex = 1;
            // 
            // button_Search
            // 
            button_Search.BackColor = Color.Transparent;
            button_Search.FlatAppearance.BorderSize = 0;
            button_Search.FlatStyle = FlatStyle.Flat;
            button_Search.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Search.ForeColor = Color.IndianRed;
            button_Search.Location = new Point(534, 21);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(88, 29);
            button_Search.TabIndex = 2;
            button_Search.Text = "Search";
            button_Search.UseVisualStyleBackColor = false;
            button_Search.Click += button_Search_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(677, 21);
            button1.Name = "button1";
            button1.Size = new Size(111, 29);
            button1.TabIndex = 3;
            button1.Text = "Download";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.IndianRed;
            button2.Location = new Point(834, 21);
            button2.Name = "button2";
            button2.Size = new Size(72, 29);
            button2.TabIndex = 4;
            button2.Text = "View";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(958, 606);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button_Search);
            Controls.Add(textBox_URL);
            Controls.Add(webView2_view);
            Name = "Bai4";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Bài 4";
            ((System.ComponentModel.ISupportInitialize)webView2_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2_view;
        private TextBox textBox_URL;
        private Button button_Search;
        private Button button1;
        private Button button2;
    }
}