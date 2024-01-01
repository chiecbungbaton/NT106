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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        private string ConvertToWord(int a)
        {
            List<string> chu = new List<string>();
            chu.Add("Không");
            chu.Add("Một");
            chu.Add("Hai");
            chu.Add("Ba");
            chu.Add("Bốn");
            chu.Add("Năm");
            chu.Add("Sáu");
            chu.Add("Bảy");
            chu.Add("Tám");
            chu.Add("Chín");
            return chu[a];
        }
        private void doc_Click(object sender, EventArgs e)
        {
            
            if (!int.TryParse(nhap.Text, out int so))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                return;
            }
            if (so < 0 || so > 9)
            {
                MessageBox.Show("Vui lòng nhập số từ 0 đến 9");
                return;
            }
           
            ketqua.Text = ConvertToWord(so);
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            nhap.Text = null;
            ketqua.Text = null;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void nhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

