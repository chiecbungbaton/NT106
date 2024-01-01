using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Http;
using System.Net;

namespace Lab4
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }
        private async void post()
        {
            try
            {
                using (var httpclient = new HttpClient())
                {
                    var request = WebRequest.Create(textBox_URL.Text) as HttpWebRequest;
                    request.Method = "POST";

                    //Get POST data from form 
                    string postData = textBox_Data.Text;

                    //Convert to byte array
                    byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                    //Set ContentLength
                    request.ContentLength = byteArray.Length;

                    // Set ContentType
                    request.ContentType = "application/x-www-form-urlencoded";

                    // Get request stream to write POST data
                    using (var dataStream = request.GetRequestStream())
                    {
                        dataStream.Write(byteArray, 0, byteArray.Length);
                    }
                    request.Timeout = 20000;
                    var responseAsync = request.GetResponseAsync();
                    var response = await responseAsync;
                    if (response != null) richTextBox_Respone.Text = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    else richTextBox_Respone.Text = "Không nhận được phản hồi";
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ex.Response as HttpWebResponse;
                    if (response != null)
                    {
                        Console.WriteLine("Mã trạng thái HTTP: {0}", response.StatusCode);
                    }
                    else MessageBox.Show("Đường dẫn không hợp lệ");
                    return;
                }
                if (ex.Status == WebExceptionStatus.Timeout)
                {
                    MessageBox.Show("Time out");
                    return;
                }
                MessageBox.Show("Lỗi");
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void button_Post_Click(object sender, EventArgs e)
        {
            post();
        }


    }
}
