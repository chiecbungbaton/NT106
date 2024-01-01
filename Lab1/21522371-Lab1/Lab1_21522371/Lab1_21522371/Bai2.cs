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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_(object sender, EventArgs e)
        {
            
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }       

        private void tim_CLick(object sender, EventArgs e)
        {
            if(!double.TryParse(so1.Text, out double a))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
                return;
            }
            if (!double.TryParse(so2.Text, out double b))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
                return;
            }
            if (!double.TryParse(so3.Text, out double c))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
                return;
            }
            List<double> list = new List<double>(){a,b,c};
            double nhonhat = list.Min();
            double lonnhat = list.Max();
            min.Text = nhonhat.ToString();
            max.Text = lonnhat.ToString();           
            
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            so1.Text = null;
            so2.Text = null;
            so3.Text = null;
            min.Text = null;
            max.Text = null;
        }
        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
