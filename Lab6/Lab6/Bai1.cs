using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab6
{
    public partial class Bai1 : Form
    {
        
        public Bai1()
        {
            InitializeComponent();
        }
        readonly string alphabet = "aáàạảãăắằặẳẵâấầậẩẫbcdđeéẹẻẽêếềệểễfghiíìịỉĩjklmnoóòọỏõôốồộổỗơớờợởỡpqrstuúùụủũưứừựửữvwxyýỳỵỷỹAÁÀẠẢÃĂẮẰẶẲẴÂẤẦẬẨẪBCDĐEÉẸẺẼÊẾỀỆỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠPQRSTUÚÙỤỦŨƯỨỪỰỬỮVWXYÝỲỴỶỸ0123456789`~!@#$%^&*()";
        private string Encrypt(string plainText, int shift)
        {
            string cipherText = "";
            foreach (char c in plainText)
            {
                if (alphabet.Contains(c))
                {
                    int offset = alphabet.IndexOf(c);
                    char newChar = alphabet[(offset + shift) % alphabet.Length];
                    cipherText += newChar;
                }
                else
                {
                    cipherText += c;
                }
            }
            return cipherText;
        }
        private string Decrypt(string cipherText, int shift)
        {
            string plainText = "";
            foreach (char c in cipherText)
            {
                if (alphabet.Contains(c))
                {
                    int offset = alphabet.IndexOf(c);
                    char newChar = alphabet[(offset - shift + alphabet.Length) % alphabet.Length];
                    plainText += newChar;
                }
                else
                {
                    plainText += c;
                }
            }
            return plainText;
        }

        private void encrypt_Click(object sender, EventArgs e)
        {   
            if (!int.TryParse(textBox_shift.Text, out int shift))
            {
                MessageBox.Show("Shift value must be an integer!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox_shift.Text))
            {
                MessageBox.Show("Shift must not be empty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            shift = Convert.ToInt32(textBox_shift.Text);
            string plaintText = data.Text;
            string cipherText = Encrypt(plaintText, shift);
            encrypted.Text = cipherText;

        }
        
        private void decrypt_Click(object sender, EventArgs e)
        {
            int shift = Convert.ToInt32(textBox_shift.Text);
            string cipherText = data.Text;
            string plaintext = Decrypt(cipherText, shift);
            decrypted.Text = plaintext;
        }
        
    }
}
