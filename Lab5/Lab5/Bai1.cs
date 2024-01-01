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

namespace Lab5
{
    public partial class Bai1 : Form
    {
        public Bai1()
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
        private void send_Click(object sender, EventArgs e)
        {
            var smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 465, true);
            try
            {
                smtpClient.Authenticate("baongannguyentra@gmail.com", "hfcruqxoxaroopzq");

                var message_ = new MimeMessage();
                message_.From.Add(new MailboxAddress("TASK 1 LAB 5 from Bảo Ngân", from.Text));
                if (IsValidEmail(to.Text) ) 
                    message_.To.Add(new MailboxAddress("", to.Text));                
                else
                {
                    MessageBox.Show("Please enter a valid email address.");
                    to.Text = "";
                    return;
                }
                message_.Subject = subject.Text;
                message_.Body = new TextPart("plain")
                {
                    Text = message.Text
                };
                smtpClient.Send(message_);
                to.Text = message.Text = subject.Text = "";
                MessageBox.Show("Message has been sent");
            }
            catch
            {
                MessageBox.Show("ERROR!\nPlease check and try again.");
            }  
        }
    }
}
