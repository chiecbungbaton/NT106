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

namespace Lab3
{
    public partial class B2_Server : Form
    {
        Socket listen;
        Socket clientSocket;
        public B2_Server()
        {
            InitializeComponent();

        }

        private void button_Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thread = new Thread(new ThreadStart(Listen));
            thread.Start();
            thread.IsBackground = true;
        }
        private void Listen()
        {
            int port = 8080;
            IPAddress ipServer = IPAddress.Parse("127.0.0.1");
            IPEndPoint iPEndPoint = new IPEndPoint(ipServer, port);
            listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listen.Bind(iPEndPoint);
            listen.Listen(-1);
            byte[] buffer = new byte[1];
            clientSocket = listen.Accept();
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    clientSocket.Receive(buffer);
                    text += Encoding.UTF8.GetString(buffer);
                } while (text[text.Length - 1] != '\n');
                richTextBox1.Text += text;
            }
            listen.Close();
        }
    }
}
