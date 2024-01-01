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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void nhap_TextChanged(object sender, EventArgs e)
        {
        }
        public int CountNumber(int a)
        {
            string sochuso = a.ToString();
            return sochuso.Length;
        }
        public static int CountDigits(int number)
        {
            string numberString = number.ToString();
            return numberString.Length;
        }
       
       


        private void doc_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(nhap.Text, out int a))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                return;
            }
                
            else
            {
                a = int.Parse(nhap.Text.Trim());
                if (a>9999||a<0)
                {
                    MessageBox.Show("Vui lòng nhập số có giá trị từ 0-9999!");
                    return;
                }    
                int s1 = Math.Abs(a) / 1000;
                int s2 = (Math.Abs(a) % 1000) / 100;
                int s3 = (Math.Abs(a) % 100) / 10;
                int s4 = (Math.Abs(a) % 100) % 10;
                List<string> donvi = new List<string> { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                List<string> chuc = new List<string> { " ","mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
                List<string> lonhon = new List<string> { "trăm", "nghìn" };
                string s = "";
                if (s1 == 0)
                {
                    if (s2 == 0)
                    {
                        if (s3 == 0)
                            s = donvi[s4];
                        else
                        {
                            if (s4 == 5)
                                s = chuc[s3] + " lăm";
                            else if (s3 == 1)
                            {
                                if (s4 == 1)
                                    s = chuc[1] + " " + donvi[1];
                                else if (s4 == 0)
                                    s = chuc[1];
                            }

                            else if (s4 == 1)
                                s = chuc[s3] + " mốt";
                            else if (s4 == 0)
                                s = chuc[s3];
                            else s = chuc[s3] + " " + donvi[s4];
                        }
                    }
                    else
                    {
                        if (s3 == 0)
                        {
                            if (s4 == 0)
                                s = donvi[s2] + " " + lonhon[0];
                            else s = donvi[s2] + " " + lonhon[0] + " lẻ " + donvi[s4];
                        }    
                            
                        else if (s4 == 5)
                            s = donvi[s2] + " " + lonhon[0] + " " + chuc[s3] + " lăm";
                        else if (s4==1)
                        {
                            if (s3 == 1)
                                s = s = donvi[s2] + " " + lonhon[0] + " " + chuc[s3] + " một";
                            else s = donvi[s2] + " " + lonhon[0] + " " + chuc[s3] + " mốt";
                        }    
                        else
                            s = donvi[s2] + " " + lonhon[0] + " " + chuc[s3]+ " " + donvi[s4];
                    } 
                }

                else
                {
                    if (s2 == 0)
                    {
                        if (s3 == 0)
                        {
                            if (s4 == 0)
                                s = donvi[s1] + " " + lonhon[1];
                            else
                            {
                                if (s4 == 1)
                                    s = donvi[s1] + " " + lonhon[1] + " " + donvi[0] + " " + lonhon[0] + " lẻ một";
                                else s = donvi[s1] + " " + lonhon[1] + " " + donvi[0] + " " + lonhon[0] + " lẻ " + donvi[s4];
                            }

                        }
                        else
                        {
                            if (s4 == 0)
                                s = donvi[s1] + " " + lonhon[1] + " " + donvi[0] + " " + lonhon[0] + " " + chuc[s3];
                            else if (s4 == 1 && s3>1)
                                s = donvi[s1] + " " + lonhon[1] + " " + donvi[0] + " " + lonhon[0] + " " + chuc[s3] + " mốt";
                            else if (s4 == 5)
                                s = donvi[s1] + " " + lonhon[1] + " " + donvi[0] + " " + lonhon[0] + " " + chuc[s3] + " lăm";
                            else s = donvi[s1] + " " + lonhon[1] + " " + donvi[0] + " " + lonhon[0] + " " + chuc[s3] + " " + donvi[s4];
                        }

                    }
                    else
                    {
                        if (s3 == 0)
                        {
                            if (s4 == 0)
                                s = donvi[s1] + " " + lonhon[1] + " " + donvi[s2] + " " + lonhon[0];
                            else if (s4 == 1)
                                s = donvi[s1] + " " + lonhon[1] + " " + donvi[s2] + " " + lonhon[0] + " lẻ mốt";
                            else s = s = donvi[s1] + " " + lonhon[1] + " " + donvi[s2] + " " + lonhon[0] + " lẻ" + donvi[s4];
                        }
                        else
                        {
                          
                            if (s4 == 0)
                                s = donvi[s1] + " " + lonhon[1] + " " + donvi[s2] + " " + lonhon[0] + " " + chuc[s3];
                            else if (s4 == 5)
                                s = donvi[s1] + " " + lonhon[1] + " " + donvi[s2] + " " + lonhon[0] + " " + chuc[s3] + " lăm";
                            else if (s4 == 1)
                            {
                                if (s3==1)
                                    s = donvi[s1] + " " + lonhon[1] + " " + donvi[s2] + " " + lonhon[0] + " " + chuc[s3] + " một";
                                else s = donvi[s1] + " " + lonhon[1] + " " + donvi[s2] + " " + lonhon[0] + " " + chuc[s3] + " mốt";
                            }    
                                
                            else s = donvi[s1] + " " + lonhon[1] + " " + donvi[s2] + " " + lonhon[0] + " " + chuc[s3] + " " + donvi[s4];
                        }



                    }
                   
                }
                ketqua.Text = s;
            }

        }
        private void xoa_Click_1(object sender, EventArgs e)
        {
            nhap.Text = null;
            ketqua.Text = null;
        }
       
        private void thoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

