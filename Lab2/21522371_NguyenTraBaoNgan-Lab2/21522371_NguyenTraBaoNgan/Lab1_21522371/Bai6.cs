using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Lab1_21522371
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void tinh_Click(object sender, EventArgs e)
        {
            //int agt = int.Parse(a.Text.ToString());
            int agt, bgt;
            if (!int.TryParse(a.Text, out agt))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                return;
            }
            
            else if (!int.TryParse(b.Text, out bgt))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                return;
            }
            else if (agt < 0 || bgt < 0)
            {
                MessageBox.Show("Không có giai thừa của số âm!");
                return;
            }
            //int bgt = int.Parse(b.Text.ToString());
            int gt1 = 1;
            int gt2 = 1;
            int s1_ = 0;
            int s2_ = 0;
            double s3_ = 0;
            double c = agt;
            for (int i = 1; i <= agt; i++)
            {
                gt1 *= i;
            }
            agiaithua.Text = gt1.ToString();

            for (int i = 1; i <= bgt; i++)
            {
                gt2 *= i;
            }

            bgiaithua.Text = gt2.ToString();
            for (int i = 0; i <= agt; i++)
            {
                s1_ += i;
            }
            s1.Text = s1_.ToString();
            for (int i = 0; i <= bgt; i++)
            {
                s2_ += i;
            }
            s2.Text = s2_.ToString();
            for (double i = 1; i <= bgt; i++)
            {
                s3_ += Math.Pow(c, i);
            }
            s3.Text = s3_.ToString();
        }
       

        private void xoa_Click_1(object sender, EventArgs e)
        {
            a.Text = null;
            b.Text = null;
            agiaithua.Text = null;
            bgiaithua.Text = null;
            s1.Text = null;
            s2.Text = null;
            s3.Text = null;
        }

        private void thoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

