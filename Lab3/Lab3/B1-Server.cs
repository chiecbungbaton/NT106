using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class B1_Server : Form
    {
        public B1_Server()
        {
            InitializeComponent();
        }

        private void listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thrUDP = new Thread(new ThreadStart(svThread));
            thrUDP.Start();           

        }
        private List<string> listmessage = new List<string>();
        private void svThread()
        {
            if (portServer.Text != "")
            {
                UdpClient udpClient = new UdpClient(Int32.Parse(portServer.Text));
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                while (true)
                {
                    IPEndPoint ipendpoint = new IPEndPoint(ip, Int32.Parse(portServer.Text));
                    listen.Enabled = false;
                    Byte[] receiveBytes = udpClient.Receive(ref ipendpoint);
                    string returnData = Encoding.UTF8.GetString(receiveBytes);
                    richTextBox1.Text += ip + ": " + returnData.ToString() + '\n';

                }
            }

        }
    }
}
