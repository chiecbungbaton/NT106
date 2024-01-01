using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Bai4_ViewMail : Form
    {
        public string user;
        public string password;
        public Bai4_ViewMail(string from, string to, string subject, string body)
        {
            InitializeComponent();
            textbox_from.Text = from;
            textbox_to.Text = to;
            label_Subject.Text = subject;
            LoadHtmlAsync(body);
        }

        private void Bai4_ViewMail_Load(object sender, EventArgs e)
        {

        }
        private async void LoadHtmlAsync(string htmlContent)
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.NavigateToString(htmlContent);
        }
        private void reply_Click(object sender, EventArgs e)
        {
            Bai4_SendMail reply = new Bai4_SendMail();
            reply.password = password;
            int startIndex = this.textbox_from.Text.IndexOf("<") + 1;
            int endIndex = this.textbox_from.Text.IndexOf(">", startIndex);
            reply.subject.Text = "RE: " + label_Subject.Text;
            reply.mailto.Text = this.textbox_from.Text.Substring(startIndex, endIndex - startIndex);
            reply.email = user;
            reply.ShowDialog();
        }
    }
}