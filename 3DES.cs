using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DES
{
    public partial class Form1 : Form
    {
        SymmetricAlgorithm tdes;
        int _blocksize = 64, _keysize = 192;
        public Form1()
        {
            InitializeComponent();
        }
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public string Encrypt(string source, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;
                    byte[] data = Encoding.Unicode.GetBytes(source);
                    return Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }
        public static string Decrypt(string encrypt, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;//CBC, CFB
                    byte[] byteBuff = Convert.FromBase64String(encrypt);
                    return Encoding.Unicode.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
                }
            }
        }
        private void getKey_Click(object sender, EventArgs e)
        {
            tdes = TripleDES.Create();
            tdes.KeySize = _keysize;
            tdes.BlockSize = _blocksize;
            tdes.GenerateKey();
            yourKey.Text = Encoding.ASCII.GetString(tdes.Key);
            byte[] key1 = new byte[8];
            byte[] key2 = new byte[8];
            byte[] key3 = new byte[8];
            Buffer.BlockCopy(tdes.Key, 0, key1, 0, 8);
            textBox1.Text = Convert.ToBase64String(key1);
            Buffer.BlockCopy(tdes.Key, 8, key2, 0, 8);
            textBox2.Text = Convert.ToBase64String(key2);
            Buffer.BlockCopy(tdes.Key, 16, key3, 0, 8);
            textBox3.Text = Convert.ToBase64String(key3);

            byte[] key192bit = new byte[24];
            Buffer.BlockCopy(key1, 0, key192bit, 0, 8);
            Buffer.BlockCopy(key2, 0, key192bit, 8, 8);
            Buffer.BlockCopy(key3, 0, key192bit, 16, 8);
            textBox4.Text = Convert.ToBase64String(key192bit);
        }



        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            var panel = sender as TableLayoutPanel;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            var rectangle = e.CellBounds;
            using (var pen = new Pen(Color.Black, 1))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

                if (e.Row == (panel.RowCount - 1))
                {
                    rectangle.Height -= 1;
                }

                if (e.Column == (panel.ColumnCount - 1))
                {
                    rectangle.Width -= 1;
                }

                e.Graphics.DrawRectangle(pen, rectangle);
            }
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            //Encrypt.ForeColor= Color.Blue;
            resultEncrypt.Text = Encrypt(inputEncrypt.Text, yourKey.Text);
            inputDecrypt.Text = resultEncrypt.Text;

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            yourKey.Text = "";
            inputEncrypt.Text = "";
            resultEncrypt.Text = "";
            inputDecrypt.Text = "";
            resultDecrypt.Text = "";
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            //Decrypt().ForeColor = Color.Blue;
            resultDecrypt.Text = Decrypt(resultEncrypt.Text, yourKey.Text);

        }


    }
}
