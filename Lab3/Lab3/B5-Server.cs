using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class B5_Server : Form
    {
        public B5_Server()
        {
            InitializeComponent();
        }
        ChatTCP_Server chat = new ChatTCP_Server(IPAddress.Any, 8080);
        private List<TcpClient> clientsList = new List<TcpClient>();
        private void listen_Click(object sender, EventArgs e)
        {
            if (!chat.checkConnect)
            {
                Connect();
            }
            else
            {
                disconnect();
            }
        }
        private void listen_Thread()
        {
            chat.server.Start();
            richTextBox1.Invoke(new MethodInvoker(delegate
            {
                formatMessage("Server running\n", HorizontalAlignment.Right);
            }));
            while (chat.checkConnect)
            {
                try
                {
                    TcpClient client = chat.server.AcceptTcpClient();
                    clientsList.Add(client);
                    Thread t = new Thread(new ThreadStart(() => acceptClient(client)));
                    t.Start();
                }
                catch { }
            }
        }
        private void sendmMuti(string data, TcpClient own)
        {
            foreach (TcpClient client in clientsList)
            {
                try
                {
                    if (client != own)
                    {
                        NetworkStream stream = client.GetStream();
                        ChatTCP_Server.send(data, stream);
                    }
                }
                catch { }
            }
        }
        private void acceptClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            while (chat.checkConnect)
            {
                try
                {
                    string data = ChatTCP_Server.receive(stream);
                    richTextBox1.Invoke(new MethodInvoker(delegate
                    {
                        formatMessage(data, HorizontalAlignment.Left);
                    }));
                    sendmMuti(data, client);
                }
                catch
                {
                }
            }
            stream.Close();
            client.Close();
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
            chat.checkConnect = true;
            listen.Text = "Disconnect";
            Thread threadListen = new Thread(listen_Thread);
            threadListen.Start();
        }
        private void disconnect()
        {
            sendmMuti("Server has stopped listening.\n", null);
            foreach (TcpClient tcpClient in clientsList)
            {
                tcpClient.Close();
            }
            chat.checkConnect = false;
            listen.Text = "Listen";
            chat.server.Stop();
        }
    }
}
