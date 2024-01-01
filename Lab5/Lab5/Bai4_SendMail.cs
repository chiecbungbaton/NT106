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
using MailKit.Net.Smtp;
using MimeKit;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel.DataAnnotations;

namespace Lab5
{
    public partial class Bai4_SendMail : Form
    {
        public Bai4_SendMail()
        {
            InitializeComponent();
        }
        public string email { get; set; }       
        public string password { get; set; }
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
        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path.Visible = true;
                path.Text = openFileDialog.FileName;
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            var smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 465, true);
            try
            {
                smtpClient.Authenticate(email, password);
            }
            catch
            {
                MessageBox.Show("Authentication error!");
            }
            var message_ = new MimeMessage();
            message_.From.Add(new MailboxAddress(name.Text, mailfrom.Text));

            if (IsValidEmail(mailto.Text))
            {
                message_.To.Add(new MailboxAddress("", mailto.Text));
            }
            else
            {
                MessageBox.Show("Invalid email");
                return;
            }
            message_.Subject = subject.Text;
            if (checkBox.Checked == false)
            {
                message_.Body = new TextPart("plain")
                {
                    Text = richTextBox1.Text
                };
            }
            else
            {
                message_.Body = new TextPart("html")
                {
                    Text = richTextBox1.Text
                };
            }
            if (!string.IsNullOrEmpty(path.Text))
            {
                var attachment = new MimePart("application", "octet-stream")
                {
                    Content = new MimeContent(File.OpenRead(path.Text)),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(path.Text)
                };
                var multipart = new Multipart("mixed");
                multipart.Add(message_.Body);
                multipart.Add(attachment);
                message_.Body = multipart;
            }               
            smtpClient.Send(message_);
            MessageBox.Show("Message has been sent");
        }

        private void Bai4_SendMail_Load(object sender, EventArgs e)
        {
            mailfrom.Text = email;
        }

        
    }
}
