using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Pop3;
using MailKit.Net.Smtp;
using MailKit.Security;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MailKit;
using MimeKit;

namespace Lab5
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }


        bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void GetMail(string username_, string password_)
        {
            var popClient = new Pop3Client();
            try
            {
                popClient.Connect("pop.gmail.com", 995, SecureSocketOptions.SslOnConnect);
                popClient.Authenticate(username_, password_);
                textbox_email.ReadOnly = true;
                textbox_password.ReadOnly = true;
                int messageCount = popClient.GetMessageCount();

                for (int i = messageCount - 1; i >= (messageCount - 10); i--)
                {
                    var message = popClient.GetMessage(i);

                    string from = message.From.ToString();
                    string subject = message.Subject;
                    string date = message.Date.ToString();

                    dataGridView1.Rows.Add(subject, from, date);
                }
                button_login.Enabled = false;
                popClient.Dispose();
            }
            catch
            {
                MessageBox.Show("Incorrect password");
                textbox_password.Text = "";
            }
        }
        private void button_login_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textbox_email.Text) || string.IsNullOrWhiteSpace(textbox_password.Text))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }
            if (!IsValidEmail(textbox_email.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            try
            {
                var smtpClient = new SmtpClient();
                smtpClient.Connect("smtp.gmail.com", 465, true);
                GetMail(textbox_email.Text, textbox_password.Text);
            }
            catch
            {
                MessageBox.Show("LOGIN FAILED");
            }
        }
    }
}