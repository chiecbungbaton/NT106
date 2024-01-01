using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void server_Click(object sender, EventArgs e)
        {
            Bai3_Server Server = new Bai3_Server();
            Server.Show();
            server.Enabled = false;
        }

        private void client_Click(object sender, EventArgs e)
        {
            Bai3_Client Client = new Bai3_Client();
            Client.Show();
        }
    }
}
