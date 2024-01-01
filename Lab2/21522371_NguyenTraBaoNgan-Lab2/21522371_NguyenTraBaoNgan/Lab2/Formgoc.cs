using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{    
    

public partial class Formgoc : Form
    {
        public Formgoc()
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

        private void bai4_Click(object sender, EventArgs e)
        {
            Bai4 b4 = new Bai4();
            b4.ShowDialog();
        }
    }
    //public static class GetDirecttoTilfe
    //{
    //    public static string directPath
    //    {
    //        get
    //        {
    //            string appPath = AppDomain.CurrentDomain.BaseDirectory;
    //            string dPath = Path.Combine(appPath, "") + @"\file";
    //            return dPath;
    //        }
    //    }
    //}


}
