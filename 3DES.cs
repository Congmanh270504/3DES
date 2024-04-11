using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
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
    public partial class tripdes : Form
    {
        SymmetricAlgorithm tdes;
        int _blocksize = 64, _keysize = 192;

        enum KeyOption
        {
            op1,
            op2,
            op3
        }
        KeyOption currentOp = KeyOption.op1;


        public tripdes()
        {
            InitializeComponent();
        }
        public void Encrypt()
        {
            DesEdeEngine engine = new DesEdeEngine();
            PaddedBufferedBlockCipher paddedBufferedBlockCipher = new PaddedBufferedBlockCipher(new EcbBlockCipher(engine), new Pkcs7Padding());
            KeyParameter keyParameter;
            switch (currentOp)
            {
                case KeyOption.op1:
                    keyParameter = new KeyParameter(Encoding.ASCII.GetBytes(subKey1.Text + subKey2.Text + subKey3.Text));
                    break;
                case KeyOption.op2:
                    keyParameter = new KeyParameter(Encoding.ASCII.GetBytes(subKey1.Text + subKey2.Text + subKey1.Text));

                    break;
                case KeyOption.op3:
                    keyParameter = new KeyParameter(Encoding.ASCII.GetBytes(subKey1.Text + subKey1.Text + subKey1.Text));
                    break;
                default:
                    throw new Exception("Loi~ ??");
            }


            paddedBufferedBlockCipher.Init(true, keyParameter);// true = encrypt 
            byte[] ip = Encoding.UTF8.GetBytes(inputEncrypt.Text);
            byte[] op = new byte[paddedBufferedBlockCipher.GetOutputSize(ip.Length)];
            int lenght = paddedBufferedBlockCipher.ProcessBytes(ip, 0, ip.Length, op, 0);
            try
            {
                paddedBufferedBlockCipher.DoFinal(op, lenght);
            }
            catch (CryptoException ce)
            {
                MessageBox.Show(ce.ToString());
            }
            resultEncrypt.Text = Convert.ToBase64String(op);
            inputDecrypt.Text = resultEncrypt.Text;

        }
        public void Decrypt()
        {
            DesEdeEngine engine = new DesEdeEngine();
            PaddedBufferedBlockCipher paddedBufferedBlockCipher = new PaddedBufferedBlockCipher(new EcbBlockCipher(engine), new Pkcs7Padding());
            KeyParameter keyParameter;
            switch (currentOp)
            {
                case KeyOption.op1:
                    keyParameter = new KeyParameter(Encoding.ASCII.GetBytes(subKey1.Text + subKey2.Text + subKey3.Text));
                    break;
                case KeyOption.op2:
                    keyParameter = new KeyParameter(Encoding.ASCII.GetBytes(subKey1.Text + subKey2.Text + subKey1.Text));

                    break;
                case KeyOption.op3:
                    keyParameter = new KeyParameter(Encoding.ASCII.GetBytes(subKey1.Text + subKey1.Text + subKey1.Text));
                    break;
                default:
                    throw new Exception("Loi~ ??");
            }

            paddedBufferedBlockCipher.Init(false, keyParameter);// false = decrypt
            byte[] ip = Convert.FromBase64String(inputDecrypt.Text);
            byte[] op = new byte[paddedBufferedBlockCipher.GetOutputSize(ip.Length)];
            int lenght = paddedBufferedBlockCipher.ProcessBytes(ip, 0, ip.Length, op, 0);
            try
            {
                paddedBufferedBlockCipher.DoFinal(op, lenght);
            }
            catch (CryptoException ce)
            {
                MessageBox.Show(ce.ToString());
            }
            resultDecrypt.Text = Encoding.UTF8.GetString(op);
        }
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void getKey_Click(object sender, EventArgs e)
        {
            switch (currentOp)
            {
                case KeyOption.op1:
                    yourKey.Text = RandomString(24);
                    subKey1.Text = yourKey.Text.Substring(0, 8);
                    subKey2.Text = yourKey.Text.Substring(8, 8);
                    subKey3.Text = yourKey.Text.Substring(16, 8);
                    break;
                case KeyOption.op2:
                    yourKey.Text = RandomString(16);
                    subKey1.Text = yourKey.Text.Substring(0, 8);
                    subKey2.Text = yourKey.Text.Substring(8, 8);
                    break;
                case KeyOption.op3:
                    yourKey.Text = RandomString(8);
                    subKey1.Text = yourKey.Text;
                    break;
                default:
                    throw new Exception("Loi~ ??");
            }

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
            ////Encrypt.ForeColor= Color.Blue;
            //resultEncrypt.Text = Encrypt(inputEncrypt.Text, yourKey.Text);
           
            Encrypt();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            yourKey.Text = "";
            inputEncrypt.Text = "";
            resultEncrypt.Text = "";
            inputDecrypt.Text = "";
            resultDecrypt.Text = "";
            subKey1.Text = "";
            subKey2.Text = "";
            subKey3.Text = "";
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Test_3DES test_3DES = new Test_3DES();
        //    test_3DES.Show();
        //}

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (currentOp != KeyOption.op1)
            {
                subKey1.Visible = true;
                subKey2.Visible = true;
                subKey3.Visible = true;
                currentOp = KeyOption.op1;
                subKey1.Text = "";
                subKey2.Text = "";
                subKey3.Text = "";
            }

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (currentOp != KeyOption.op2)
            {
                subKey1.Visible = true;
                subKey2.Visible = true;
                subKey3.Visible = false;
                currentOp = KeyOption.op2;
                subKey1.Text = "";
                subKey2.Text = "";
                subKey3.Text = "";
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (currentOp != KeyOption.op3)
            {
                subKey1.Visible = true;
                subKey2.Visible = false;
                subKey3.Visible = false;
                currentOp = KeyOption.op3;
                subKey1.Text = "";
                subKey2.Text = "";
                subKey3.Text = "";
            }
        }


        private void subKey2_TextChanged(object sender, EventArgs e)
        {

        }



        private void Decrypt_Click(object sender, EventArgs e)
        {
            //Decrypt().ForeColor = Color.Blue;
            //resultDecrypt.Text = Decrypt(resultEncrypt.Text, yourKey.Text);
            Decrypt();
        }


    }
}
