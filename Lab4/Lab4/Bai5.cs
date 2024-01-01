using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }
        int pagenumber;

        Label lbpage = new Label();

        private void button_get_Click(object sender, EventArgs e)
        {
            getHTML(1);
            next.Enabled = true;
            button_get.Enabled = false;
        }
        private void getHTML(int page)
        {
            panel1.Controls.Clear();
            lbpage.Controls.Clear();
            pagenumber = page;
            string szUrl = "https://reqres.in/api/users?page=";
            WebRequest request = WebRequest.Create(szUrl + page); // Create a request for the URL.
            WebResponse response = request.GetResponse(); // Get the response.             
            Stream dataStream = response.GetResponseStream(); // Get the stream containing content returned by the server.             
            StreamReader reader = new StreamReader(dataStream); // Open the stream using a StreamReader for easy access.             
            string responseFromServer = reader.ReadToEnd(); // Read the content.             
            response.Close(); // Close the response. 

            var data = JsonSerializer.Deserialize<UserPagination>(responseFromServer);
            pagenumber = data.Page;

            //add label page
            lbpage.Text = "Page: " + data.Page;
            lbpage.Location = new Point(37, 23);
            lbpage.Size = new Size(150, 20);
            this.Controls.Add(lbpage);

            //add label totalpage
            Label lbtotalpage = new Label();
            lbtotalpage.Text = "Total page: " + data.TotalPages;
            lbtotalpage.Location = new Point(300, 23);
            lbtotalpage.Size = new Size(150, 20);
            this.Controls.Add(lbtotalpage);

            //add label user/page
            Label lbuserperpage = new Label();
            lbuserperpage.Text = "User/page: " + data.PerPage;
            lbuserperpage.Location = new Point(37, 60);
            lbuserperpage.Size = new Size(150, 20);
            this.Controls.Add(lbuserperpage);

            //add label total user
            Label lbtotaluser = new Label();
            lbtotaluser.Text = "Total user: " + data.Total;
            lbtotaluser.Location = new Point(300, 60);
            lbtotaluser.Size = new Size(150, 20);
            this.Controls.Add(lbtotaluser);

            //show objects
            int spacing = 50; // Spacing between objects
            int y = 0; // first object's location
            progressBar1.Minimum = 0;
            progressBar1.Maximum = data.Data.Count;
            progressBar1.Value = 0;
            foreach (var item in data.Data)
            {
                Label lbName = new Label();
                lbName.Text = item.FirstName + " " + item.LastName;
                lbName.Size = new Size(200, 20); // Label size
                lbName.Location = new Point(0, y);
                lbName.Font = new Font(lbName.Font, FontStyle.Bold);
                panel1.Controls.Add(lbName);

                Label lbmail = new Label();
                lbmail.Text = item.Email;
                lbmail.Size = new Size(200, 20);
                lbmail.Location = new Point(0, y + lbName.Height + spacing);
                panel1.Controls.Add(lbmail);

                PictureBox pbAvatar = new PictureBox();
                pbAvatar.ImageLocation = item.Avatar;
                pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                pbAvatar.Location = new Point(panel1.Width - panel1.Width / 4, y + (pbAvatar.Height - lbName.Height - lbmail.Height) / 2);
                pbAvatar.Size = new Size(100, 100);
                panel1.Controls.Add(pbAvatar);

                // update the next object's location
                lbName.Location = new Point(pbAvatar.Height / 2 - 1, pbAvatar.Top + (pbAvatar.Height - lbName.Height - lbmail.Height) / 2);
                lbmail.Location = new Point(pbAvatar.Height / 2 + 1, pbAvatar.Top + lbName.Height + (pbAvatar.Height - lbName.Height - lbmail.Height) / 2);
                y = y + pbAvatar.Height + spacing;
                progressBar1.Value++;
            }
        }

        class User
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }
            [JsonPropertyName("email")]
            public string Email { get; set; }
            [JsonPropertyName("first_name")]
            public string FirstName { get; set; }
            [JsonPropertyName("last_name")]
            public string LastName { get; set; }
            [JsonPropertyName("avatar")]
            public string Avatar { get; set; }
        }

        class UserPagination
        {
            [JsonPropertyName("page")]
            public int Page { get; set; }
            [JsonPropertyName("per_page")]
            public int PerPage { get; set; }
            [JsonPropertyName("total")]
            public int Total { get; set; }
            [JsonPropertyName("total_pages")]
            public int TotalPages { get; set; }
            [JsonPropertyName("data")]
            public List<User> Data { get; set; }
        }

        private void next_Click(object sender, EventArgs e)
        {
            getHTML(pagenumber + 1);
            next.Enabled = false;
            back.Enabled = true;

        }

        private void back_Click(object sender, EventArgs e)
        {
            getHTML(pagenumber - 1);
            next.Enabled = true;
            back.Enabled = false;
        }
    }
}
