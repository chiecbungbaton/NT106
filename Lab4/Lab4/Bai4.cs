using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Lab4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            try
            {
                if (textBox_URL.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter the path");
                    return;
                }
                webView2_view.Source = new Uri(textBox_URL.Text);
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form form_source = new Form();

                string source;
                using (HttpClient client = new HttpClient())
                {
                    var respone = await client.GetAsync(webView2_view.Source);
                    source = await respone.Content.ReadAsStringAsync();
                }
                RichTextBox richTextBox_Soucre = new RichTextBox();
                richTextBox_Soucre.Dock = DockStyle.Fill;
                richTextBox_Soucre.Text = source;
                form_source.Controls.Add(richTextBox_Soucre);
                form_source.Size = new Size(630, 600);
                form_source.ShowDialog();
            }
            catch
            {
                MessageBox.Show("There was an ERROR during viewing source");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (webView2_view.Source == null) return;
            try
            {
                var web = new HtmlWeb();
                var doc = web.Load(webView2_view.Source);
                //Thread threadhtml = new Thread(delegate()
                {
                    using (WebClient client = new WebClient())
                    {
                        // Tải nội dung của trang web vào một chuỗi
                        string htmlContent = client.DownloadString(webView2_view.Source);

                        // Lưu trữ nội dung vào một tệp tin
                        string filePath = webView2_view.Source.Host + ".html";
                        File.WriteAllText(filePath, htmlContent);
                    }
                }
                // Lấy danh sách link hình ảnh và file
                var imageLinks = doc.DocumentNode
                                        .SelectNodes("//img[@src]")
                                        .Select(n => n.Attributes["src"].Value)
                                        .ToList();

                var fileLinks = doc.DocumentNode
                                   .SelectNodes("//a[@href]")
                                   .Select(n => n.Attributes["href"].Value)
                                   .Where(l => l.EndsWith(".pdf") || l.EndsWith(".doc"))
                                   .ToList();

                // Download các hình ảnh và file 
                foreach (var link in imageLinks)
                {
                    try
                    {
                        var fileName = Path.GetFileName(link);

                        using (WebClient client = new WebClient())
                        {
                            client.DownloadFile(link,fileName);
                        }
                    }
                    catch { }
                }
                foreach (var link in fileLinks)
                {
                    try
                    {
                        var fileName = Path.GetFileName(link);

                        using (WebClient client = new WebClient())
                        {
                            client.DownloadFile(link, fileName);
                        }
                    }
                    catch { }
                }
                MessageBox.Show("Download successfully!");
            }
            catch
            {
                MessageBox.Show("There was an ERROR during downloading");
            }
        }
    }
}
