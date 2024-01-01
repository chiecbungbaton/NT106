using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }
        private bool CheckKey(string text)
        {
            return Regex.IsMatch(text, @"^[a-zA-Z\p{P}]+$");
        }
        private bool CheckData(string text)
        {
            return Regex.IsMatch(text, @"^[a-zA-Z\s\p{P}]+$");
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (!CheckData(data.Text))
            {
                MessageBox.Show("Input data must be an English text and contains only letters!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox_key.Text))
            {
                MessageBox.Show("Key must not be empty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!CheckKey(textBox_key.Text))
            {
                MessageBox.Show("Key must be an English alphabetic string excluding spaces!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string plainText = data.Text;
            string key = textBox_key.Text;
            string cipherText = Encrypt(plainText, key);
            encrypted.Text = cipherText;
        }

        private void decrypt_Click(object sender, EventArgs e)
        {           
            string cipherText = data.Text;
            string key = textBox_key.Text;
            string plaintext = Decrypt(cipherText, key);
            decrypted.Text = plaintext;
        }
        private string Encrypt(string plainText, string key)
        {
            string cipherText = "";
            int keyIndex = 0;
            foreach (char c in plainText)
            {
                if (char.IsLetter(c))
                {
                    int offset = char.ToLower(key[keyIndex]) - 'a';
                    int shift = char.IsLower(c) ? 'a' : 'A';
                    char newChar = (char)((((int)c - shift + offset) % 26) + shift);
                    cipherText += newChar;
                    keyIndex = (keyIndex + 1) % key.Length;
                }
                else
                {
                    cipherText += c;
                }
            }
            return cipherText;
        }

        private string Decrypt(string cipherText, string key)
        {
            string plainText = "";
            int keyIndex = 0;
            foreach (char c in cipherText)
            {
                if (char.IsLetter(c))
                {
                    int offset = char.ToLower(key[keyIndex]) - 'a';
                    int shift = char.IsLower(c) ? 'a' : 'A';
                    char newChar = (char)((((int)c - shift - offset + 26) % 26) + shift);
                    plainText += newChar;
                    keyIndex = (keyIndex + 1) % key.Length;
                }
                else
                {
                    plainText += c;
                }
            }
            return plainText;
        }
    }
}
