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
        enum KeyOption
        {
            op1,
            op2,
            op3
        }
        KeyOption currentOp = KeyOption.op1;
        enum Mode
        {
            ECB, CBC, CFB, OFB, CTR
        }
        Mode mode = Mode.ECB;

        public tripdes()
        {
            InitializeComponent();
        }
        public void Encrypt()
        {
            DesEdeEngine engine = new DesEdeEngine();
            PaddedBufferedBlockCipher cipher;
            switch (mode)
            {
                case Mode.ECB:
                    cipher = new PaddedBufferedBlockCipher(new EcbBlockCipher(engine), new Pkcs7Padding());
                    break;
                case Mode.CBC:
                    cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(engine), new Pkcs7Padding());
                    break;
                case Mode.CFB:
                    cipher = new PaddedBufferedBlockCipher(new CfbBlockCipher(engine, 8), new Pkcs7Padding());
                    break;
                case Mode.OFB:
                    cipher = new PaddedBufferedBlockCipher(new OfbBlockCipher(engine, 8), new Pkcs7Padding());
                    break;
                case Mode.CTR:
                    cipher = new PaddedBufferedBlockCipher(new SicBlockCipher(engine), new Pkcs7Padding());
                    break;
                default:
                    throw new Exception("Loi~ ??");

            }
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
            if (mode == Mode.ECB)
            {
                cipher.Init(true, keyParameter);// true = encrypt 
            }
            else
            {
                ParametersWithIV parametersWithIV = new ParametersWithIV(keyParameter, Encoding.ASCII.GetBytes(yourIV.Text));
                cipher.Init(true, parametersWithIV);// true = encrypt 
            }
            byte[] ip = Encoding.UTF8.GetBytes(inputEncrypt.Text);
            byte[] op = new byte[cipher.GetOutputSize(ip.Length)];
            int lenght = cipher.ProcessBytes(ip, 0, ip.Length, op, 0);
            try
            {
                cipher.DoFinal(op, lenght);
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
            PaddedBufferedBlockCipher cipher;
            switch (mode)
            {
                case Mode.ECB:
                    cipher = new PaddedBufferedBlockCipher(new EcbBlockCipher(engine), new Pkcs7Padding());
                    break;
                case Mode.CBC:
                    cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(engine), new Pkcs7Padding());
                    break;
                case Mode.CFB:
                    cipher = new PaddedBufferedBlockCipher(new CfbBlockCipher(engine, 8), new Pkcs7Padding());
                    break;
                case Mode.OFB:
                    cipher = new PaddedBufferedBlockCipher(new OfbBlockCipher(engine, 8), new Pkcs7Padding());
                    break;
                case Mode.CTR:
                    cipher = new PaddedBufferedBlockCipher(new SicBlockCipher(engine), new Pkcs7Padding());
                    break;
                default:
                    throw new Exception("Loi~ ??");

            }
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
            if (mode == Mode.ECB)
            {
                cipher.Init(false, keyParameter);// false = decrypt 
            }
            else
            {
                ParametersWithIV parametersWithIV = new ParametersWithIV(keyParameter, Encoding.ASCII.GetBytes(yourIV.Text));
                cipher.Init(false, parametersWithIV);// false = decrypt 
            }

            byte[] ip = Convert.FromBase64String(inputDecrypt.Text);
            byte[] op = new byte[cipher.GetOutputSize(ip.Length)];
            int lenght = cipher.ProcessBytes(ip, 0, ip.Length, op, 0);
            try
            {
                cipher.DoFinal(op, lenght);
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
            Encrypt();
        }
        private void Decrypt_Click(object sender, EventArgs e)
        {
            Decrypt();
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
            yourIV.Text = "";
            radioButton1.Checked = true;
            radioECB.Checked = true;
            label7.Visible = false;
            yourIV.Visible = false;
            getIV.Visible = false;
        }
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

        private void radioECB_CheckedChanged(object sender, EventArgs e)
        {
            if (mode != Mode.ECB)
            {
                label7.Visible = false;
                yourIV.Visible = false;
                getIV.Visible = false;
                mode = Mode.ECB;
                yourIV.Text = "";
            }

        }

        private void radioCBC_CheckedChanged(object sender, EventArgs e)
        {
            if (mode != Mode.CBC)
            {
                label7.Visible = true;
                yourIV.Visible = true;
                getIV.Visible = true;
                mode = Mode.CBC;
                yourIV.Text = "";
            }
        }

        private void radioCFB_CheckedChanged(object sender, EventArgs e)
        {
            if (mode != Mode.CFB)
            {
                label7.Visible = true;
                yourIV.Visible = true;
                getIV.Visible = true;
                mode = Mode.CFB;
                yourIV.Text = "";
            }
        }
        private void radioOFB_CheckedChanged(object sender, EventArgs e)
        {
            if (mode != Mode.OFB)
            {
                label7.Visible = true;
                yourIV.Visible = true;
                getIV.Visible = true;
                mode = Mode.OFB;
                yourIV.Text = "";
            }
        }
        private void radioCTR_CheckedChanged(object sender, EventArgs e)
        {
            if (mode != Mode.CTR)
            {
                label7.Visible = true;
                yourIV.Visible = true;
                getIV.Visible = true;
                mode = Mode.CTR;
                yourIV.Text = "";
            }
        }
        private void getIV_Click(object sender, EventArgs e)
        {
            if (mode == Mode.ECB)
            {
                throw new Exception("Loi~ ??");
            }
            else
            {
                yourIV.Text = RandomString(8);
            }

        }

        private void yourKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            switch (currentOp)
            {
                case KeyOption.op1:
                    if (yourKey.Text.Length != 24)
                    {
                        MessageBox.Show("Wrong key size must be 24 character!!");
                    }
                    else
                    {
                        subKey1.Text = yourKey.Text.Substring(0, 8);
                        subKey2.Text = yourKey.Text.Substring(8, 8);
                        subKey3.Text = yourKey.Text.Substring(16, 8);
                    }
                    break;
                case KeyOption.op2:
                    if (yourKey.Text.Length != 16)
                    {
                        MessageBox.Show("Wrong key size must be 16 character!!");
                    }
                    else
                    {
                        subKey1.Text = yourKey.Text.Substring(0, 8);
                        subKey2.Text = yourKey.Text.Substring(8, 8);
                    }
                    break;
                case KeyOption.op3:
                    if (yourKey.Text.Length != 8)
                    {
                        MessageBox.Show("Wrong key size must be 8 character!!");
                    }
                    else
                    {
                        subKey1.Text = yourKey.Text.Substring(0, 8);
                    }
                    break;
                default:
                    throw new Exception("Loi~ ??");
            }
        }

        private void tripdes_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
            yourIV.Visible = false;
            getIV.Visible = false;
        }

        private void inputEncrypt_gotFocus(object sender, EventArgs e)
        {
            if (inputEncrypt.Text == "Enter plain text to hash")
            {
                inputEncrypt.Text = "";
            }
        }
        private void inputEncrypt_lostFocus(object sender, EventArgs e)
        {
            if (inputEncrypt.Text == "")
            {
                inputEncrypt.Text = "Enter plain text to hash";
            }
        }
        private void inputDecrypt_gotFocus(object sender, EventArgs e)
        {
            if (inputDecrypt.Text == "Enter text to Decrypt")
            {
                inputDecrypt.Text = "";
            }
        }
        private void inputDecrypt_lostFocus(object sender, EventArgs e)
        {
            if (inputDecrypt.Text == "")
            {
                inputDecrypt.Text = "Enter text to Decrypt";
            }
        }
        private void yourKey_gotFocus(object sender, EventArgs e)
        {
            if (yourKey.Text == "Enter Key")
            {
                yourKey.Text = "";
            }
        }
        private void yourKey_lostFocus(object sender, EventArgs e)
        {
            if (yourKey.Text == "")
            {
                yourKey.Text = "Enter Key";
            }
        }

       
    }
}
