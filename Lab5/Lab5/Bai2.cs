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
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Security;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MailKit;
using MimeKit;

namespace Lab5
{
    public partial class Bai2 : Form
    {
        public Bai2()
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
            var imapClient = new ImapClient();
            try
            {
                imapClient.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                imapClient.Authenticate(username_, password_);
                textbox_email.ReadOnly = true;
                textbox_password.ReadOnly = true;
                var inboxMail = imapClient.Inbox;
                inboxMail.Open(FolderAccess.ReadOnly);

                var messages = inboxMail.Fetch(0, -1, MessageSummaryItems.UniqueId | MessageSummaryItems.Envelope 
                    | MessageSummaryItems.BodyStructure).OrderByDescending(x => x.Date).Take(10); // Get the 10 most recent messages
                int index = 1;
                foreach (var message in messages)
                {
                    var from = message.Envelope.From.ToString();
                    var subject = message.Envelope.Subject;
                    var date = message.Date.LocalDateTime.ToString();


                    var row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = subject });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = from });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = date });

                    dataGridView1.Rows.Add(row);
                    index++;
                }
                imapClient.Dispose();
            }
            catch
            {
                MessageBox.Show("Incorrect password");
                textbox_password.Text = "";
            }
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            try
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
