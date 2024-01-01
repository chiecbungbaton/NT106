using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_21522371
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void so2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tong_TextChanged(object sender, EventArgs e)
        {

        }

        private void nuttong_CLick(object sender, EventArgs e)
        {       
            
            if (!int.TryParse(so1.Text, out int a))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }
            if (!int.TryParse(so2.Text, out int b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }
            int c = a + b;
            tong.Text = c.ToString();
        }
    }
}
