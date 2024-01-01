namespace Lab3
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }


        private void server_Click_1(object sender, EventArgs e)
        {
            B1_Server b1_server = new B1_Server();
            b1_server.Show();
        }

        private void client_Click_1(object sender, EventArgs e)
        {
            B1_Client b1_client = new B1_Client();
            b1_client.Show();
        }

        private void start_Click(object sender, EventArgs e)
        {
            B2_Server b2_server = new B2_Server();
            b2_server.Show();
        }

        private void serverb3_Click(object sender, EventArgs e)
        {
            B3_Server b3_server = new B3_Server();
            b3_server.Show();
        }

        private void clientb3_Click(object sender, EventArgs e)
        {
            B3_Client b3_client = new B3_Client();
            b3_client.Show();
        }

        private void server1b4_Click(object sender, EventArgs e)
        {
            B4_Server1 b4_server = new B4_Server1();
            b4_server.Show();
        }

        private void server2b4_Click(object sender, EventArgs e)
        {
            B4_Server2 b4_Server2 = new B4_Server2();
            b4_Server2.Show();
        }



        private void serverb5_Click(object sender, EventArgs e)
        {
            B5_Server b5_server = new B5_Server();
            b5_server.Show();
        }

        private void clientb5_Click(object sender, EventArgs e)
        {
            B5_Client b5_client = new B5_Client();
            b5_client.Show();
        }

        private void clientb4_Click(object sender, EventArgs e)
        {
            B4_Client b4_client = new B4_Client();
            b4_client.Show();
        }
    }
}