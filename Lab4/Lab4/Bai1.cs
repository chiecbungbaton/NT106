using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Lab4
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void getlink_Click(object sender, EventArgs e)
        {
            richtextbox.Clear();
            string url = link.Text;
            Uri uriResult;
            bool isValidUrl = Uri.TryCreate(url, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (isValidUrl)
            {
                try
                {
                    HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
                    WebResponse response = request.GetResponse();
                    Stream st = response.GetResponseStream();
                    StreamReader sr = new StreamReader(st);
                    string responsefromServer = sr.ReadToEnd();
                    richtextbox.Text = responsefromServer;
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
                            richtextbox.Text = responseText;
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

    }
}
