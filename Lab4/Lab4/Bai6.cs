using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HtmlAgilityPack;
using Microsoft.Web.WebView2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }
        
        private async void get()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Dispose();
            }
            flowLayoutPanel1.Controls.Clear();
            HtmlWeb htmlWeb = new HtmlWeb();
            try
            {
                var docHtml = htmlWeb.Load(textBox_URL.Text);
                var articles = docHtml.DocumentNode.SelectNodes("//article");
                int count = articles.Count();
                int i = 0;
                progressBar1.Maximum = count;
                foreach (var article in articles)
                {
                    try
                    {
                        // Kiểm tra xem phần tử "h2/a" có tồn tại hay không
                        HtmlNode titleNode = article.SelectSingleNode("h2/a");
                        string title = (titleNode != null) ? titleNode.InnerText.Trim() : "";
                        if (title == "")
                        {
                            titleNode = article.SelectSingleNode("h3/a");
                            title = (titleNode != null) ? titleNode.InnerText.Trim() : "";
                        }

                        // Kiểm tra xem phần tử "p" có tồn tại hay không
                        HtmlNode descriptionNode = article.SelectSingleNode("p");
                        string description = (descriptionNode != null) ? descriptionNode.InnerText.Trim() : "";

                        // Kiểm tra xem phần tử "div/a/picture/img" có tồn tại hay không
                        HtmlNode imageNode = article.SelectSingleNode("div/a/picture/img");
                        string image = (imageNode != null && imageNode.Attributes["data-src"] != null) ? imageNode.Attributes["data-src"].Value : "";
                        if (image == "") image = (imageNode != null && imageNode.Attributes["src"] != null) ? imageNode.Attributes["src"].Value : "";
                        if (image == "")
                        {
                            imageNode = article.SelectSingleNode("div/a/img");
                            image = (imageNode != null && imageNode.Attributes["src"] != null) ? imageNode.Attributes["src"].Value : "";
                        }

                        // Kiểm tra xem thuộc tính "href" của phần tử "h2/a" có tồn tại hay không
                        HtmlNode tagNode = article.SelectSingleNode("h2/a");
                        if (tagNode == null) tagNode = article.SelectSingleNode("h3/a");
                        if (tagNode != null)
                        {
                            string tag = (tagNode != null && tagNode.Attributes["href"] != null) ? tagNode.Attributes["href"].Value : "";
                            Panel panel = new Panel();
                            panel.Size = new Size(flowLayoutPanel1.Size.Width - 30, 130);
                            ///////////////////

                            Label label1 = new Label();
                            label1.Text = title;
                            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                            label1.AutoSize = true;
                            label1.MaximumSize = new Size(panel.Size.Width / 2 + 30, panel.Height);
                            label1.Tag = tag;
                            label1.Click += label_Click;
                            panel.Controls.Add(label1);
                            //////////////

                            Label label2 = new Label();
                            label2.Text = description;
                            label2.Location = new Point(panel.Location.X, label1.Height + 10);
                            label2.AutoSize = true;
                            label2.MaximumSize = new Size(panel.Size.Width / 2 + 10, panel.Height);
                            label2.Tag = tag;
                            label2.Click += label_Click;
                            panel.Controls.Add(label2);
                            if (image.Trim() != "")
                            {
                                WebClient webClient = new WebClient();
                                byte[] imageData = webClient.DownloadData(image);
                                MemoryStream memoryStream = new MemoryStream(imageData);
                                //////////////////////////////////////////

                                PictureBox pictureBox = new PictureBox();
                                pictureBox.Location = new Point(panel.Location.X + panel.Width - 200, panel.Location.Y);
                                pictureBox.Size = new Size(200, panel.Size.Height);
                                pictureBox.Image = Image.FromStream(memoryStream);
                                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                pictureBox.Tag = tag;
                                pictureBox.Click += img_Click;
                                panel.Controls.Add(pictureBox);
                            }
                            panel.Tag = tag;
                            panel.MouseDown += panel_Click;
                            panel.BorderStyle = BorderStyle.FixedSingle;
                            flowLayoutPanel1.Controls.Add(panel);
                        }
                    }
                    catch { }
                    i++;
                    progressBar1.Value = i;
                }
            } catch {
                MessageBox.Show("ERROR!");
            }
        }

        private void panel_Click(object sender, EventArgs e)
        {
            Panel sen = (Panel)sender;
            WebView2 webView2 = new WebView2();
            webView2.Dock = DockStyle.Fill;
            webView2.Source = (new Uri(sen.Tag.ToString()));
            Form form = new Form();
            form.Size=new Size(720,640);
            form.Controls.Add(webView2);
            form.ShowDialog();
        }
        private void label_Click(object sender, EventArgs e)
        {
            Label sen = (Label)sender;
            WebView2 webView2 = new WebView2();
            webView2.Dock = DockStyle.Fill;
            webView2.Source = (new Uri(sen.Tag.ToString()));
            Form form = new Form();
            form.Size = new Size(720, 640);
            form.Controls.Add(webView2);
            form.ShowDialog();
        }
        private void img_Click(object sender, EventArgs e)
        {
            PictureBox sen = (PictureBox)sender;
            WebView2 webView2 = new WebView2();
            webView2.Dock = DockStyle.Fill;
            webView2.Source = (new Uri(sen.Tag.ToString()));
            Form form = new Form();
            form.Size = new Size(720, 640);
            form.Controls.Add(webView2);
            form.ShowDialog();
        }

        private void button_Get_Click_1(object sender, EventArgs e)
        {
            get();
        }
    }
}
