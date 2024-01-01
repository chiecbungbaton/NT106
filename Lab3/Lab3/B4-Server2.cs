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
    public partial class B4_Server2 : Form
    {

        ChatTCP_Server chat = new ChatTCP_Server(IPAddress.Parse("127.0.0.1"), 8080);
        public B4_Server2()
        {
            InitializeComponent();
        }
        private void Listen()
        {
            while (chat.checkConnect)
            {
                try
                {
                    chat.server.Start();

                    listView1.Invoke(new MethodInvoker(delegate
                    {
                        ListViewItem listItem = new ListViewItem("");
                        listItem.SubItems.Add("Server bắt đầu lắng nghe");
                        listView1.Items.Add(listItem);
                    }));
                go_to:

                    TcpClient client = chat.server.AcceptTcpClient();
                    using (NetworkStream stream = client.GetStream())
                    {
                        while (client.Connected && chat.checkConnect)
                        {

                            string data = ChatTCP_Server.receive(stream);
                            if (data != "" && chat.checkConnect)
                            {
                                listView1.Invoke((MethodInvoker)delegate
                                {
                                    listView1.Items.Add(data);
                                });
                            }
                            stream.Flush();
                            if (client.Client.Poll(0, SelectMode.SelectRead))
                            {
                                stream.Close();
                                client.Close();
                                goto go_to;
                            }
                        }
                    }
                    client.Close();
                    chat.server.Stop();
                }
                catch { }
            }

        }
        private void Disconnet()
        {
            chat.server.Stop();
        }
        private void button_Listen_Click(object sender, EventArgs e)
        {
            if (!chat.checkConnect)
            {
                chat.checkConnect = true;
                button_Listen.Text = "Disconnect";
                Thread threadListen = new Thread(Listen);
                threadListen.Start();
            }
            else
            {
                ListViewItem listItem = new ListViewItem("");
                listItem.SubItems.Add("Server ngắt kết nối");
                listView1.Items.Add(listItem);
                chat.checkConnect = false;
                Disconnet();
                button_Listen.Text = "Listen";
            }
        }
    }
}
