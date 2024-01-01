using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace Lab3
{
    public partial class B4_Client : Form
    {
        TcpClient Client;
        bool _isconnect = false;
        public B4_Client()
        {
            InitializeComponent();
        }

        private void send()
        {
            if (textBox_Send.Text.Trim() != "")
            {
                try
                {
                    NetworkStream stream = Client.GetStream();
                    ChatTCP_Server.send(textBox_UserName.Text + ": " + textBox_Send.Text, stream);
                    formatMessage(textBox_Send.Text + '\n', HorizontalAlignment.Right);
                    textBox_Send.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi kết nối");
                }
            }
        }
        private void receive()
        {
            //while (_isconnect)
            //{
            //    try
            //    {

            //        byte[] buffe = new byte[1024 * 32];
            //        NetworkStream stream = Client.GetStream();
            //        stream.Read(buffe);
            //        string data = ChatTCP_Server.receive(stream);
            //        if (data ==)
            //    }
            //    catch
            //    {
            //    }
            //}
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (_isconnect)
            {
                send();
            }
            else
            {
                MessageBox.Show("Vui lòng kết nối tới server");
            }
        }
        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_isconnect)
                {
                    Client = new TcpClient();
                    _isconnect = true;
                    Client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080));
                    ChatTCP_Server.send("User " + textBox_UserName.Text + " đã kết nối tới server", Client.GetStream());
                    formatMessage("Kết nối tới server thành công\n", HorizontalAlignment.Left);
                    button_Connect.Text = "Disconnect";
                    Thread thread = new Thread(receive);
                    thread.Start();
                    Thread threadreconnect = new Thread(reconnect);
                    threadreconnect.Start();
                }
                else
                {
                    ChatTCP_Server.send("User " + textBox_UserName.Text + " đã ngắt kết nối", Client.GetStream());
                    _isconnect = false;
                    Client.Close();
                    formatMessage("Ngắt kết nối tới server\n", HorizontalAlignment.Left);
                    button_Connect.Text = "Connect";
                }
            }
            catch
            {
                _isconnect = false;
                button_Connect.Text = "Connect";
                Client.Close();
            }
        }
        private void formatMessage(string message, HorizontalAlignment type)
        {
            int lastLineIndex = richTextBox_Message.GetLineFromCharIndex(richTextBox_Message.Text.Length);
            int lastLineStartIndex = richTextBox_Message.GetFirstCharIndexFromLine(lastLineIndex);
            richTextBox_Message.SelectionStart = lastLineStartIndex;
            richTextBox_Message.SelectionAlignment = type;
            richTextBox_Message.AppendText(message);
        }
        private void textBox_Send_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                send();
            }
        }
        private void reconnect()
        {
            while (_isconnect)
            {
                try
                {
                    if (Client.Client.Poll(0, SelectMode.SelectRead) && _isconnect)
                    {
                        MessageBox.Show("server bị lỗi đang kết nối lại");
                        Client.Close();
                        Client = new TcpClient();
                        Client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080));
                    }
                }
                catch { }
            }
        }


    }
}
