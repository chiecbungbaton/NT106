using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }
        
        private void read_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.ShowDialog();
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string filePath = openFileDialog1.FileName;
            richTextBox.Text = sr.ReadToEnd();
            fs.Close();
            sr.Close();

            //show file info
            //name
            filename_.Text = openFileDialog1.SafeFileName.ToString();
            //size            
            FileInfo fileInfo = new FileInfo(filePath);
            long fileSizeInBytes = fileInfo.Length;
            size_.Text = fileSizeInBytes.ToString() + " bytes";
            //url
            url_.Text = fs.Name.ToString();
            //count line
            string[] lines = File.ReadAllLines(filePath);
            int lineCount = lines.Length;
            linecount_.Text = lineCount.ToString();
            //count word
            string fileContent = File.ReadAllText(filePath);
            string[] words = fileContent.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = 0;
            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    wordCount++;
                }
            }
            wordcount_.Text = wordCount.ToString();

            //count character 
            //string charCount = File.ReadAllText(filePath);
            int charCount = fileContent.Length;
            charactercount_.Text = charCount.ToString();
        }
    

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
