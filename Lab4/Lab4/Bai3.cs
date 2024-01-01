using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void down_Click(object sender, EventArgs e)
        {
            WebClient myClient = new WebClient();
            if (url.Text == "")
            {
                MessageBox.Show("Please enter the URL!");
                return;
            }
            Stream response = myClient.OpenRead(url.Text);
            string extension = System.IO.Path.GetExtension(path.Text);
            if (extension != ".html" || path.Text == "")
            {
                MessageBox.Show("The file must be in HTML format.");
                return;
            }

            else
            {
                try
                {
                    myClient.DownloadFile(url.Text, path.Text);
                    richTextBox.Clear();
                    string url_ = url.Text;
                    Uri uriResult;
                    bool isValidUrl = Uri.TryCreate(url_, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
                    if (isValidUrl)
                    {
                        try
                        {
                            //show content on richtextbox
                            HttpWebRequest request = HttpWebRequest.Create(url_) as HttpWebRequest;
                            WebResponse response_ = request.GetResponse();
                            Stream st = response_.GetResponseStream();
                            StreamReader sr = new StreamReader(st);
                            string responsefromServer = sr.ReadToEnd();
                            richTextBox.Text = responsefromServer;

                            //download file
                            string responsefromServer_ = myClient.DownloadString(url_);

                            //close
                            response.Close();
                        }
                        catch (WebException ex)
                        {
                            if (ex.Response != null)
                            {
                                using (Stream stream = ex.Response.GetResponseStream())
                                using (StreamReader reader = new StreamReader(stream))
                                {
                                    string responseText = reader.ReadToEnd();
                                    richTextBox.Text = responseText;
                                }
                            }
                            else
                                MessageBox.Show("This page could not be found!");

                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid URL");
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid PATH");
                }

            }


        }
    }
}
