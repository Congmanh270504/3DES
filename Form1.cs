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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TripleDES.
            Output.Text = EncryptText(Input.Text);
        }
        private string EncryptText(string plaintext)
        {
            // Get Key and IV from Base64 string
            byte[] key = Convert.FromBase64String(Key1.Text);

            // Create tdes object
            tdes = TripleDES.Create();
            tdes.Key = key;

            // Create Encryptor
            ICryptoTransform transform = tdes.CreateEncryptor();
            MemoryStream ms = new MemoryStream(); // Create a memory stream to write the encrypted data to
            CryptoStream cs = new CryptoStream(ms, transform, CryptoStreamMode.Write); // Create a CryptoStream to encrypt the data
            StreamWriter sw = new StreamWriter(cs); // Create a StreamWriter to write the data to the CryptoStream

            sw.Write(plaintext); // Write the data to the CryptoStream
            sw.Close(); // Close the StreamWriter
            cs.Close(); // Close the CryptoStream
            byte[] buffer = ms.ToArray(); // Get the encrypted data from the MemoryStream
            ms.Close(); // Close the MemoryStream

            return Convert.ToBase64String(buffer); // Return the encrypted data as a Base64 string
        }

        private string DecryptText(string plaintext)
        {
            // Get Key and IV from Base64 string
            byte[] key = Convert.FromBase64String(Key1.Text);

            // Create tdes object
            tdes = TripleDES.Create();
            tdes.Key = key;

            // Create Encryptor
            ICryptoTransform transform = tdes.CreateDecryptor();
            MemoryStream ms = new MemoryStream(); // Create a memory stream to write the encrypted data to
            CryptoStream cs = new CryptoStream(ms, transform, CryptoStreamMode.Write); // Create a CryptoStream to encrypt the data
            StreamWriter sw = new StreamWriter(cs); // Create a StreamWriter to write the data to the CryptoStream

            sw.Write(plaintext); // Write the data to the CryptoStream
            sw.Close(); // Close the StreamWriter
            cs.Close(); // Close the CryptoStream
            byte[] buffer = ms.ToArray(); // Get the encrypted data from the MemoryStream
            ms.Close(); // Close the MemoryStream

            return Convert.ToBase64String(buffer); // Return the encrypted data as a Base64 string
        }
        private void getKey_Click(object sender, EventArgs e)
        {
            tdes = TripleDES.Create();
            tdes.GenerateKey();
            Key1.Text = Convert.ToBase64String(tdes.Key);
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

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
