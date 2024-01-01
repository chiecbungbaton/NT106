using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Lab6
{
    public partial class Bai3_Client : Form
    {
        IPAddress ipServer = IPAddress.Parse("127.0.0.1");
        const int portServer = 8080;
        TcpClient tcpClient;
        NetworkStream networkStream;
        bool checkConnect = false;
        public Bai3_Client()
        {
            InitializeComponent();
        }
        private void Connect()
        {
            try
            {
                int lastLineIndex = richTextBox_chatRoom.GetLineFromCharIndex(richTextBox_chatRoom.Text.Length);
                int lastLineStartIndex = richTextBox_chatRoom.GetFirstCharIndexFromLine(lastLineIndex);
                richTextBox_chatRoom.SelectionStart = lastLineStartIndex;
                richTextBox_chatRoom.SelectionAlignment = HorizontalAlignment.Left;
                richTextBox_chatRoom.AppendText(". . . . . . . . . . . . . . . . . . . . . .\n");
                tcpClient = new TcpClient();
                tcpClient.Connect(ipServer, portServer);
                networkStream = tcpClient.GetStream();
                checkConnect = true;
                SocketTCP.Send(networkStream, textBox_Name.Text + ": connected to server");
                Thread threadRec = new Thread(new ThreadStart(Receive));
                threadRec.Start();
                button_connect.Text = "Disconnect";
                button_Send.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới server!");
            }
        }
        private void Receive()
        {

            while (checkConnect)
            {
                try
                {
                    string data = SocketTCP.Receive(networkStream);
                    if (data != null)
                    {
                        richTextBox_chatRoom.Invoke(new MethodInvoker(delegate
                        {
                            int lastLineIndex = richTextBox_chatRoom.GetLineFromCharIndex(richTextBox_chatRoom.Text.Length);
                            int lastLineStartIndex = richTextBox_chatRoom.GetFirstCharIndexFromLine(lastLineIndex);
                            richTextBox_chatRoom.SelectionStart = lastLineStartIndex;
                            richTextBox_chatRoom.SelectionAlignment = HorizontalAlignment.Left;
                            richTextBox_chatRoom.AppendText(data + "\n");
                        }));
                        if (data == "Server stopped listen!")
                        {
                            checkConnect = false;
                            tcpClient.Close();
                            networkStream.Close();
                            button_Send.Invoke(new MethodInvoker(delegate { button_Send.Enabled = false; }));
                            button_connect.Invoke(new MethodInvoker(delegate { button_connect.Text = "Connect"; }));
                        }
                    }
                }
                catch { }
            }
        }
        private void send(string data)
        {
            SocketTCP.Send(networkStream, textBox_Name.Text + ": " + data);
            int lastLineIndex = richTextBox_chatRoom.GetLineFromCharIndex(richTextBox_chatRoom.Text.Length);
            int lastLineStartIndex = richTextBox_chatRoom.GetFirstCharIndexFromLine(lastLineIndex);
            richTextBox_chatRoom.SelectionStart = lastLineStartIndex;
            richTextBox_chatRoom.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox_chatRoom.AppendText(data + "\n");
            richTextBox_Message.Text = null;
        }
        private void Disconnect()
        {
            button_connect.Text = "Connect";
            button_Send.Enabled = false;
            checkConnect = false;
            send("Disconnected to server");
            tcpClient.Close();
            networkStream.Close();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            send(richTextBox_Message.Text);
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (!checkConnect)
            {
                Connect();
            }
            else
            {
                Disconnect();
            }
        }

        private void Bai3_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect();
        }
    }
}
