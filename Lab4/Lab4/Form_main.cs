namespace Lab4
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void bai1_Click(object sender, EventArgs e)
        {
            Bai1 b1 = new Bai1();
            b1.ShowDialog();
        }
        private void bai2_Click(object sender, EventArgs e)
        {
            Bai2 b2 = new Bai2();
            b2.ShowDialog();
        }
        private void bai3_Click(object sender, EventArgs e)
        {
            Bai3 b3 = new Bai3();
            b3.ShowDialog();
        }
        private void bai4_Click(object sender, EventArgs e)
        {
            Bai4 b4 = new Bai4();
            b4.ShowDialog();
        }

        private void bai5_Click(object sender, EventArgs e)
        {
            Bai5 b5 = new Bai5();
            b5.ShowDialog();
        }

        private void bai6_Click(object sender, EventArgs e)
        {
            Bai6 b6 = new Bai6();
            b6.ShowDialog();
        }
    }
}