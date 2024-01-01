using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_21522371
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }
        string xe = "";
        private void loaixe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaixe.SelectedItem.ToString()=="Wave Alpha")
            {
                xe = "Wave Alpha";

            }   
            else if (loaixe.SelectedItem.ToString()=="Sirius")
            {
                xe = "Sirius";
            }
            else if (loaixe.SelectedItem.ToString()=="Vision")
            {
                xe = "Vision";
            }
            else if (loaixe.SelectedItem.ToString()=="Lead")
            {
                xe = "Lead";
            }
            else if (loaixe.SelectedItem.ToString() == "Winner")
            {
                xe = "Winner";
            }
            else if (loaixe.SelectedItem.ToString() == "AirBlade")
            {
                xe = "AirBlade";
            }
            else
            {
                xe = "Xe tải";
            }
            if (xe == "Xe tải")
            {
                loaixang.Items.Clear();
                loaixang.Items.Add("Dầu DO");

            }
            else if (xe == "Lead" || xe == "Winner" || xe == "AirBlade")
            {
                loaixang.Items.Clear();
                loaixang.Items.Add("RON 95 III");
            }
            else
            {
                loaixang.Items.Clear();
                loaixang.Items.Add("RON 95 III");
                loaixang.Items.Add("E5 RON 92 II");

            }

        }

        private void tinh_Click(object sender, EventArgs e)
        {
            if (loaixe.Text=="Wave Alpha")
            {
                double giatien;
                double sokm = 3.7 * 62.5;

                if (loaixang.Text=="RON 95 III")      
                    giatien = 3.7 * 26830;                  
                else 
                    giatien = 3.7 * 26070;

                km.Text = Math.Round(sokm, 2).ToString() + " Km";
                tien.Text = Math.Round(giatien, 2).ToString() + " VNĐ";

            }  
            else if (loaixe.Text=="Sirius")
            {
                double giatien;
                double sokm = 3.8 * 100 / 1.99;

                if (loaixang.Text == "RON 95 III")
                    giatien = 3.8 * 26830;
                else
                    giatien = 3.8 * 26070;

                km.Text = Math.Round(sokm, 2).ToString() + " Km";
                tien.Text = Math.Round(giatien, 2).ToString() + " VNĐ";
            }
            else if (loaixe.Text == "Vision")
            {
                double giatien;
                double sokm = 5.2 * 100 / 1.87;

                if (loaixang.Text == "RON 95 III")
                    giatien = 5.2 * 26830;
                else
                    giatien = 5.2 * 26070;

                km.Text = Math.Round(sokm, 2).ToString() + " Km";
                tien.Text = Math.Round(giatien, 2).ToString() + " VNĐ";
            }
            else if (loaixe.Text == "Lead")
            {
                double giatien = 6 * 26830;
                double sokm = 6 * 100 / 2.02;
                km.Text = Math.Round(sokm, 2).ToString() + " Km";
                tien.Text = Math.Round(giatien, 2).ToString() + " VNĐ";
            }
            else if (loaixe.Text == "Winner")
            {
                double giatien = 4.5 * 26830;
                double sokm = 4.5 * 100 / 1.7;
                km.Text = Math.Round(sokm, 2).ToString() + " Km";
                tien.Text = Math.Round(giatien, 2).ToString() + " VNĐ";
            }
            else if (loaixe.Text == "AirBlade")
            {
                double giatien = 4.4 * 26830;
                double sokm = 4.4 * 100 / 2.17;
                km.Text = Math.Round(sokm, 2).ToString() + " Km";
                tien.Text = Math.Round(giatien, 2).ToString() + " VNĐ";
            }
            else 
            {
                double giatien = 70 * 21310;
                double sokm = (double)70 * 100 / 13;
                km.Text = Math.Round(sokm, 2).ToString() + " Km";
                tien.Text = Math.Round(giatien, 2).ToString() + " VNĐ";
            }
        }

        private void loaixang_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            loaixang.Text = "";
            loaixe.Text = "";
            km.Text = "";
            tien.Text = "";
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
