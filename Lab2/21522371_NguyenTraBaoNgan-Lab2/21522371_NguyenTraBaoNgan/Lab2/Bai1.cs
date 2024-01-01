using Microsoft.VisualBasic.ApplicationServices;

namespace Lab2
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void docfile_Click(object sender, EventArgs e)
        {
            mo_file.Filter = "Text files (*.txt)|*.txt";
            mo_file.ShowDialog();
            FileStream fs = new FileStream(mo_file.FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            richtextbox1.Text = sr.ReadToEnd();
            fs.Close();
        }

        private void ghifile_Click(object sender, EventArgs e)
        {
            mo_file.Filter = "Text files (*.txt)|*.txt";
            mo_file.ShowDialog();
            FileStream fs1 = new FileStream(mo_file.FileName, FileMode.Truncate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine(richtextbox1.Text.ToUpper());
            MessageBox.Show("File đã được ghi lại!");
            sw.Close(); 
            fs1.Close();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
    }
}