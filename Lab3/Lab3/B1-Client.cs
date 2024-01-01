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
    public partial class B1_Client : Form
    {
        public B1_Client()
        {
            InitializeComponent();
        }
        List<string> message = new List<string>();
        private void send_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            Byte[] sendBytes = Encoding.UTF8.GetBytes(richTextBox.Text);
            udpClient.Send(sendBytes,sendBytes.Length,ipAdd.Text,Int32.Parse(portClient.Text));
            richTextBox.Clear();            
        }
    }
}
