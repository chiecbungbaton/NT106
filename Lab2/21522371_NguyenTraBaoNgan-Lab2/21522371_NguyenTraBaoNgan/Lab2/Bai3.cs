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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void read_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\BAO NGAN\Desktop\21522371_NguyenTraBaoNgan\21522371_NguyenTraBaoNgan\Lab2\inputbai3.txt";
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            richTextBox1.Text = sr.ReadToEnd();
            fs.Close();
        }

        

        private void write_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.ShowDialog();
            FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            try {
                foreach (string s in richTextBox1.Lines)            
                {
                    double temp = Convert.ToDouble(new DataTable().Compute(s, ""));
                    sw.WriteLine(s + " = " + temp.ToString());                   
                }
                MessageBox.Show("File đã được ghi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
            sw.Close();
            
        }
    }
}
