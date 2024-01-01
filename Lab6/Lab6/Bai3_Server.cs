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

namespace Lab6
{
    public partial class Bai3_Server : Form
    {
        TcpListener server;
        bool checkConnect = false;
        List<TcpClient> listClient = new List<TcpClient>();
        public Bai3_Server()
        {
            InitializeComponent();
        }

        private void button_Listen_Click(object sender, EventArgs e)
        {
            if (!checkConnect)
            {
                Thread threadListen = new Thread(Listen);
                threadListen.Start();
                button_Listen.Text = "Stop";
            }
            else
            {
                Stop();
                button_Listen.Text = Text = "Listen";
            }
        }
        private void Listen()
        {
            server = new TcpListener(IPAddress.Any, 8080);
            server.Start();
            richTextBox_chatRoom.Invoke(new MethodInvoker(delegate
            {
                int lastLineIndex = richTextBox_chatRoom.GetLineFromCharIndex(richTextBox_chatRoom.Text.Length);
                int lastLineStartIndex = richTextBox_chatRoom.GetFirstCharIndexFromLine(lastLineIndex);
                richTextBox_chatRoom.SelectionStart = lastLineStartIndex;
                richTextBox_chatRoom.SelectionAlignment = HorizontalAlignment.Right;
                richTextBox_chatRoom.AppendText("Server running\n");
            }));
            checkConnect = true;
            while (checkConnect)
            {
                try
                {
                    TcpClient tcpClient = server.AcceptTcpClient();
                    if (tcpClient != null)
                    {
                        listClient.Add(tcpClient);
                        Thread threadClient = new Thread(new ThreadStart(() => AcceptClient(tcpClient)));
                        threadClient.Start();
                    }
                }
                catch { }
            }
        }
        private void AcceptClient(TcpClient tcpClient)
        {
            NetworkStream stream = tcpClient.GetStream();
            SocketTCP.Send(stream, "Connect to the server successfull");
            while (checkConnect)
            {
                try
                {
                    string data = ReceiveAndBroadcast(tcpClient);
                    if (data != null && data.Split(':')[1] == " Disconnected to server")
                    {
                        listClient.Remove(tcpClient);
                        tcpClient.Close();
                        stream.Close();
                        return;
                    }
                }
                catch { }
            }
        }
        private string ReceiveAndBroadcast(TcpClient tcpClient)
        {
            NetworkStream stream = tcpClient.GetStream();
            string data = SocketTCP.Receive(stream);
            if (data != null)
            {
                foreach (TcpClient client in listClient)
                {

                    try
                    {
                        if (client != tcpClient)
                        {
                            SocketTCP.Send(client.GetStream(), data);
                        }
                    }
                    catch { }
                }
                richTextBox_chatRoom.Invoke(new MethodInvoker(delegate
                {
                    int lastLineIndex = richTextBox_chatRoom.GetLineFromCharIndex(richTextBox_chatRoom.Text.Length);
                    int lastLineStartIndex = richTextBox_chatRoom.GetFirstCharIndexFromLine(lastLineIndex);
                    richTextBox_chatRoom.SelectionStart = lastLineStartIndex;
                    richTextBox_chatRoom.SelectionAlignment = HorizontalAlignment.Left;
                    richTextBox_chatRoom.AppendText(data + "\n");
                }));
            }
            return data;
        }
        private void Stop()
        {
            try
            {
                int lastLineIndex = richTextBox_chatRoom.GetLineFromCharIndex(richTextBox_chatRoom.Text.Length);
                int lastLineStartIndex = richTextBox_chatRoom.GetFirstCharIndexFromLine(lastLineIndex);
                richTextBox_chatRoom.SelectionStart = lastLineStartIndex;
                richTextBox_chatRoom.SelectionAlignment = HorizontalAlignment.Right;
                richTextBox_chatRoom.AppendText("Server stopped listen\n");
                foreach (TcpClient client in listClient)
                {
                    NetworkStream stream = client.GetStream();
                    SocketTCP.Send(stream, "Server stopped listen!");
                    stream.Close();
                    client.Close();
                }
                checkConnect = false;
                server.Stop();
                listClient.Clear();
            }
            catch { }
        }

        private void Button_Listen_Click_1(object sender, EventArgs e)
        {
            if (!checkConnect)
            {
                Thread threadListen = new Thread(Listen);
                threadListen.Start();
                Button_Listen.Text = "Stop";
            }
            else
            {
                Stop();
                Button_Listen.Text = Text = "Listen";
            }
        }

        private void Bai3_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }
    }
}
