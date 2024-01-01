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
using MailKit.Search;
using System.Reflection;

namespace Lab5
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        public List<string> linkMail = new List<string>();
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
            var client = new ImapClient();
            try
            {
                client.Connect(imapBox.Text, Int16.Parse(imapPort.Text), SecureSocketOptions.SslOnConnect);
                client.Authenticate(username_, password_);
                logout.Visible = true;
                refresh.Visible = true;
                sendMail.Visible = true;
                username.ReadOnly = true;
                password.ReadOnly = true;
                var inboxMail = client.Inbox;
                inboxMail.Open(FolderAccess.ReadOnly);
                // Get the 10 most recent messages
                var messages = inboxMail.Fetch(0, -1, MessageSummaryItems.UniqueId | MessageSummaryItems.Envelope 
                    | MessageSummaryItems.Body).OrderByDescending(x => x.Date).Take(10);
                int index = 1;
                foreach (var message in messages)
                {
                    var email = inboxMail.GetMessage(message.UniqueId);
                    var from = message.Envelope.From.ToString();
                    var subject = message.Envelope.Subject;
                    var date = message.Date.LocalDateTime.ToString();

                    var row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell
                    {
                        Value = index.ToString(),
                        Tag = email.HtmlBody
                    });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = from });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = subject });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = date });
                    dataGridView.Rows.Add(row);
                    index++;
                }

            }
            catch
            {
                MessageBox.Show("Incorrect password");
                logout.Visible = false;
                refresh.Visible = false;
                sendMail.Visible = false;
                username.ReadOnly = false;
                password.ReadOnly = false;
            }            
            client.Disconnect(true);

        }
        private void login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }
            if (!IsValidEmail(username.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            try
            {
                var smtpClient = new SmtpClient();
                smtpClient.Connect("smtp.gmail.com", 465, true);
                GetMail(username.Text, password.Text);
            }
            catch
            {
                MessageBox.Show("LOGIN FAILED");
            }
        }
        

        private void logout_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            logout.Visible = false;
            refresh.Visible = false;
            sendMail.Visible = false;
            login.Visible = true;
            username.Text = "";
            username.ReadOnly = false;
            password.Text = "";
            password.ReadOnly = false;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            login_Click(sender, e);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void sendMail_Click(object sender, EventArgs e)
        {
            Bai4_SendMail sendMail = new Bai4_SendMail();
            sendMail.email = username.Text;
            sendMail.password = password.Text;
            sendMail.ShowDialog();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var body = dataGridView.Rows[e.RowIndex].Cells[0].Tag;
            // Thêm phần lấy gmail để đồng bộ qua From To bên viewMail
            string from = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            string to=username.Text;
            string subject= dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            Bai4_ViewMail viewMail = new Bai4_ViewMail(from,to,subject,body.ToString());
            viewMail.user = username.Text;
            viewMail.password = password.Text;
            viewMail.ShowDialog();
        }
    }
}
