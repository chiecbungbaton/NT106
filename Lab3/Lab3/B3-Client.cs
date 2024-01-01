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
    public partial class B3_Client : Form
    {

        public B3_Client()
        {
            InitializeComponent();
        }
        private TcpClient client;
        private NetworkStream stream;
        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                int port = 8080;
                IPEndPoint ipendpoint = new IPEndPoint(ip, port);
                client = new TcpClient();
                client.Connect(ipendpoint);
                stream = client.GetStream();
                byte[] data = Encoding.UTF8.GetBytes("CONNECTED TO THE CLIENT AT " + ip + " PORT " + port + '\n');
                stream.Write(data, 0, data.Length);
                connect.Enabled = false;
                send.Enabled = true;
                disconnect.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error!");
            }            
        }
        private void send_Click(object sender, EventArgs e)
        {
            Byte[] message = Encoding.UTF8.GetBytes(richTextBox1.Text);
            stream.Write(message, 0, message.Length);
            richTextBox1.Clear();
        }
        private void disconnect_Click(object sender, EventArgs e)
        {
            byte[] datas = Encoding.UTF8.GetBytes("Disconnecting...");
            stream.Write(datas, 0, datas.Length);
            client.Close();
            stream.Close();
            disconnect.Enabled = false;
            send.Enabled = false;
            connect.Enabled = true;
        }
    }
}
