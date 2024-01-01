using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class B5_Client : Form
    {
        public B5_Client()
        {
            InitializeComponent();
        }
        private TcpClient client;
        private NetworkStream stream;
        bool ischeckConnect = false;
        private void send_Click(object sender, EventArgs e)
        {
            sendfunction();
        }
        private void recevie()
        {
            while (ischeckConnect)
            {
                try
                {
                    string data = ChatTCP_Server.receive(stream);
                    richTextBox1.Invoke(new MethodInvoker(delegate
                    {
                        formatMessage(data + '\n', HorizontalAlignment.Left);
                    }));
                    if (client.Client.Poll(0, SelectMode.SelectRead)) Disconnect();
                }
                catch { }
            }
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ischeckConnect)
                {
                    Connect();
                }
                else
                {
                    Disconnect();
                }
            }
            catch
            {
            }
        }
        private void formatMessage(string message, HorizontalAlignment type)
        {

            int lastLineIndex = richTextBox1.GetLineFromCharIndex(richTextBox1.Text.Length);
            int lastLineStartIndex = richTextBox1.GetFirstCharIndexFromLine(lastLineIndex);
            richTextBox1.SelectionStart = lastLineStartIndex;
            richTextBox1.SelectionAlignment = type;
            richTextBox1.AppendText(message);
        }
        private void Connect()
        {
            if (name.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên");
                return;
            }
            client = new TcpClient();
            client.Connect(IPAddress.Parse("127.0.0.1"), 8080);
            stream = client.GetStream();
            ChatTCP_Server.send(name.Text + " has connected.\n", stream);
            formatMessage("Connecting successfully!\n", HorizontalAlignment.Left);
            Thread thread = new Thread(recevie);
            thread.Start();
            ischeckConnect = true;
            button_Connect.Text = "Disconnect";
            name.ReadOnly = true;
        }
        private void Disconnect()
        {
            try
            {
                ischeckConnect = false;
                name.ReadOnly = false;
                ChatTCP_Server.send(name.Text + " has disconnected.\n", stream);
                button_Connect.Text = "Connect";
                client.Close();
                stream.Close();
            }
            catch { }
        }
        private void sendfunction()
        {
            if (mess.Text.Trim() != "" && ischeckConnect)
            {
                try
                {
                    ChatTCP_Server.send(name.Text + ": " + mess.Text + "\n", stream);
                    formatMessage(mess.Text + '\n', HorizontalAlignment.Right);
                    mess.Text = "";
                }
                catch { }
            }
        }

        private void mess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendfunction();
            }
        }
    }
}
