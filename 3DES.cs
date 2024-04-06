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
        int _blocksize = 64, _keysize = 168;
        public Form1()
        {
            InitializeComponent();
        }

        public string Encrypt(string source, string key)
        {
            engine
            return null;
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
            yourKey.Text = Convert.ToBase64String(tdes.Key);
            
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

        private void Decrypt_Click(object sender, EventArgs e)
        {
            //Decrypt().ForeColor = Color.Blue;
            resultDecrypt.Text = Decrypt(resultEncrypt.Text, yourKey.Text);

        }

        
    }
}
