namespace Lab5
{
    partial class Bai4_ViewMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai4_ViewMail));
            textbox_from = new TextBox();
            textbox_to = new TextBox();
            reply = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            label_Subject = new Label();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // textbox_from
            // 
            textbox_from.BackColor = SystemColors.ControlLightLight;
            textbox_from.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textbox_from.Location = new Point(90, 20);
            textbox_from.Name = "textbox_from";
            textbox_from.ReadOnly = true;
            textbox_from.Size = new Size(302, 27);
            textbox_from.TabIndex = 1;
            // 
            // textbox_to
            // 
            textbox_to.BackColor = SystemColors.ControlLightLight;
            textbox_to.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textbox_to.Location = new Point(90, 51);
            textbox_to.Name = "textbox_to";
            textbox_to.ReadOnly = true;
            textbox_to.Size = new Size(302, 27);
            textbox_to.TabIndex = 2;
            // 
            // reply
            // 
            reply.BackColor = Color.Transparent;
            reply.FlatAppearance.BorderColor = Color.Green;
            reply.FlatStyle = FlatStyle.Flat;
            reply.Location = new Point(436, 15);
            reply.Name = "reply";
            reply.Size = new Size(100, 68);
            reply.TabIndex = 3;
            reply.UseVisualStyleBackColor = false;
            reply.Click += reply_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 147);
            webView21.Name = "webView21";
            webView21.Size = new Size(538, 500);
            webView21.TabIndex = 4;
            webView21.ZoomFactor = 1D;
            // 
            // label_Subject
            // 
            label_Subject.AutoSize = true;
            label_Subject.BackColor = Color.Transparent;
            label_Subject.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Subject.ForeColor = Color.FromArgb(125, 153, 117);
            label_Subject.Location = new Point(27, 95);
            label_Subject.MaximumSize = new Size(520, 100);
            label_Subject.Name = "label_Subject";
            label_Subject.Size = new Size(0, 22);
            label_Subject.TabIndex = 5;
            // 
            // Bai4_ViewMail
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(562, 669);
            Controls.Add(label_Subject);
            Controls.Add(webView21);
            Controls.Add(reply);
            Controls.Add(textbox_to);
            Controls.Add(textbox_from);
            MaximizeBox = false;
            Name = "Bai4_ViewMail";
            Text = "Bai4_ViewMail";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textbox_from;
        private TextBox textbox_to;
        private Button reply;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Label label_Subject;
    }
}