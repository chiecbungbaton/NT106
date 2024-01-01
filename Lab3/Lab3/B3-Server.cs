using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab3
{
    public partial class B3_Server : Form
    {
        public B3_Server()
        {
            InitializeComponent();
        }
        private TcpListener server;
        private TcpClient client;

        private void listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thrTCP = new Thread(new ThreadStart(sv_Thread));
            thrTCP.Start();
            listen.Enabled = false;
        }
        private void sv_Thread()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 8080;
            try
            {
                server = new TcpListener(ip, port);
                server.Start();
                client = server.AcceptTcpClient();
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] data = new byte[1024];
                    int bytes = stream.Read(data, 0, data.Length);
                    string message = Encoding.UTF8.GetString(data, 0, bytes);
                    richTextBox.Text += message;
                    while (true)
                    {
                        byte[] buffer = new byte[1024];
                        int receive = stream.Read(buffer, 0, buffer.Length);
                        string rcvmessage = Encoding.UTF8.GetString(buffer, 0, receive);
                        if (rcvmessage == "Disconnecting...")
                        {
                            richTextBox.Text += "CLIENT HAS DISCONNECTED.\n";
                            break;
                        }
                        else
                            richTextBox.Text += "Client: " + rcvmessage + '\n';
                    }
                    server.Stop();
                    client.Close();
                    Thread newThr = new Thread(new ThreadStart(sv_Thread));
                    newThr.Start();
                }
            }
            catch
            {
                MessageBox.Show("Error!");

            }
        }
    }
}
