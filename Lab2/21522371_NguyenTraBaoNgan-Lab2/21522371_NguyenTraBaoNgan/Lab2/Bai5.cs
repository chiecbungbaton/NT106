using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Lab2
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void compress_Click(object sender, EventArgs e)
        {
            if (inputdata.Text.Trim()=="")
            {
                MessageBox.Show("Please enter the data!");
                return;
            }
            // Get data from textbox
            string data = inputdata.Text;            
            string compressedFile = @"C:\Users\BAO NGAN\Desktop\21522371_NguyenTraBaoNgan\21522371_NguyenTraBaoNgan\Lab2\outputbai5.zip";
            try
            {
                using (ZipArchive archive = ZipFile.Open(compressedFile, ZipArchiveMode.Create))
                {
                    // Create an ZipArchiveEntry object for adding data to Zip
                    ZipArchiveEntry entry = archive.CreateEntry("outputbai5.txt");

                    // Write data from TextBox to Zip file
                    using (StreamWriter writer = new StreamWriter(entry.Open()))
                    {
                        writer.Write(data);
                    }
                }
                MessageBox.Show("Compress successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("This textbox has been compressed before!");
            }

        }      
        private void decompress_Click(object sender, EventArgs e)
        {
            //Unzipping outputbai5.zip and save to outputbai5.txtx
            try
            {
                string zipPath = @"C:\Users\BAO NGAN\Desktop\21522371_NguyenTraBaoNgan\21522371_NguyenTraBaoNgan\Lab2\outputbai5.zip"; // Đường dẫn đến tệp tin zip
                string extractPath = @"C:\Users\BAO NGAN\Desktop\21522371_NguyenTraBaoNgan\21522371_NguyenTraBaoNgan\Lab2"; // Đường dẫn đến thư mục để giải nén tập tin
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                MessageBox.Show("Decompress successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("This textbox has been decompressed before!");
            }
        }
    }
    
}
