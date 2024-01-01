using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_21522371
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void chia_Click(object sender, EventArgs e)
        {
            try
            {
                string input = nhapip.Text.Trim();
                //check ip IPv4 4 với các octet được ngăn cách bởi 4 dấu chấm
                string[] octets = input.Split('.');
                if (octets.Length != 4)
                {
                    MessageBox.Show("Địa chỉ IPv4 không hợp lệ");
                    return;
                }
                else
                {
                    try
                    {
                        foreach (string octet in octets)
                        {
                            int value = int.Parse(octet);
                            if (value < 0 || value > 255)
                            {
                                MessageBox.Show("Địa chỉ IPv4 không hợp lệ");
                                return;
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Địa chỉ IPv4 không hợp lệ");
                    }
                }
                string address = input;
                string subnetMask=subnet.Text.Trim();
                //check subnetmask theo IPv4 4 với các octet được ngăn cách bởi 4 dấu chấm
                string[] octetsmask = subnetMask.Split('.');
                if (octetsmask.Length != 4)
                {
                    MessageBox.Show("Subnet mask không hợp lệ");
                    return;
                }
                else
                {
                    try
                    {
                        foreach (string octet in octetsmask)
                        {
                            int value = int.Parse(octet);
                            if (value < 0 || value > 255)
                            {
                                MessageBox.Show("Subnet mask không hợp lệ");
                                return;
                            }
                        }

                        string binary_mask = string.Join("", octetsmask.Select(x => Convert.ToString(int.Parse(x), 2).PadLeft(8, '0')));
                        if (binary_mask.Contains("01"))
                        {
                            MessageBox.Show("Subnet mask không hợp lệ");
                            return;
                        }
                        
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Subnet mask không hợp lệ");
                        return;
                    }
                }
                if (int.Parse(somangcon.Text) < 1)
                {
                    MessageBox.Show("Số mạng con phải là 1 số nguyên dương!");
                    return;
                }    
                int numSubnets = int.Parse(somangcon.Text);

               DataTable table = SubnetCalculating.CalculateSubnets(address, subnetMask, numSubnets);
               bangchiasubnet.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            bangchiasubnet.DataSource = null;
            nhapip.Text = null;
            subnet.Text = null;
            somangcon.Text = null;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void somangcon_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

    public static class SubnetCalculating
    {
        public static DataTable CalculateSubnets(string address, string subnetMask, int numSubnets)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(address, out ip) || ip.AddressFamily != AddressFamily.InterNetwork)
            {                
                throw new ArgumentException("Địa chỉ không hợp lệ, vui lòng nhập lại!");      
            }
            
            IPAddress mask;
            if (!IPAddress.TryParse(subnetMask, out mask))
            {
                throw new ArgumentException("Subnetmask không hợp lệ, vui lòng nhập lại!");
            }
            //trường hợp ip và subnetmask kh cùng loại
            if (mask.AddressFamily != ip.AddressFamily)
            {
                throw new ArgumentException("Vui lòng nhập subnet mask cùng loại với địa chỉ IP");
            }

            byte[] ipBytes = ip.GetAddressBytes();
            byte[] maskBytes = mask.GetAddressBytes();

            //tính số bit trong subnet mask
            int numMaskBits = 0;
            for (int i = 0; i < maskBytes.Length; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    if ((maskBytes[i] & (1 << j)) != 0)
                    {
                        numMaskBits++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            // tính số bit host

            // tính số subnet và số host mỗi subnet
            int numSubnetBits = (int)Math.Ceiling(Math.Log(numSubnets, 2));
            int numHostBits = 32 - numMaskBits-numSubnetBits;
            if (numHostBits < 2)
            {
                throw new ArgumentException("Số mạng con vượt quá số bit cho phép!");
            }
            int numHostsPerSubnet = (int)Math.Pow(2,numHostBits) - 2;

            // tính địa chỉ mạng 
            byte[] subnetBytes = new byte[ipBytes.Length];
            for (int i = 0; i < subnetBytes.Length; i++)
            {
                subnetBytes[i] = (byte)(ipBytes[i] & maskBytes[i]);
            }
            IPAddress subnetAddress = new IPAddress(subnetBytes);

            // lệnh tạo bảng
            DataTable table = new DataTable();
            table.Columns.Add("STT", typeof(int));
            table.Columns.Add("Địa chỉ mạng", typeof(string));
            table.Columns.Add("Địa chỉ đầu", typeof(string));
            table.Columns.Add("Địa chỉ cuối", typeof(string));
            table.Columns.Add("Địa chỉ Broadcast", typeof(string));

            // thêm hàng vào bảng cho mỗi subnet
            for (int i = 0; i <Math.Pow(2,numSubnetBits); i++)
            {
                byte[] subnetIdBytes = BitConverter.GetBytes(i*(numHostsPerSubnet+2));
                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(subnetIdBytes);

                }
                for (int j = 0; j < subnetBytes.Length; j++)
                {
                    subnetBytes[j] = (byte)(ipBytes[j] & maskBytes[j]);
                }
                for (int j = 0; j < subnetIdBytes.Length; j++)
                {
                    subnetBytes[j] |= subnetIdBytes[j];
                }
                IPAddress subnetId = new IPAddress(subnetBytes);

                byte[] firstHostBytes = new byte[ipBytes.Length];
                for (int j = 0; j < firstHostBytes.Length; j++)
                {
                    firstHostBytes[j] = subnetBytes[j];
                }
                firstHostBytes[firstHostBytes.Length - 1]++;

                byte[] lastHostBytes = new byte[ipBytes.Length];
                for (int j = 0; j < lastHostBytes.Length; j++)
                {
                    lastHostBytes[j] = subnetBytes[j];
                }
                byte[] numHostsPerSubnetbyte=BitConverter.GetBytes(numHostsPerSubnet);
                Array.Reverse(numHostsPerSubnetbyte);
                for (int j=0;j<4;j++)
                {
                    lastHostBytes[j]+=numHostsPerSubnetbyte[j];
                }    
                byte[] broadcastBytes = new byte[ipBytes.Length];
                Array.Copy(lastHostBytes, broadcastBytes, lastHostBytes.Length);
                broadcastBytes[lastHostBytes.Length - 1]++;
                IPAddress firstHost = new IPAddress(firstHostBytes);
                IPAddress lastHost = new IPAddress(lastHostBytes);
                IPAddress broadcast = new IPAddress(broadcastBytes);
                table.Rows.Add(i + 1, subnetId.ToString(), firstHost.ToString(), lastHost.ToString(), broadcast.ToString());
            }
            return table;
        }
    }
}
    
    

