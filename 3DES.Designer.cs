namespace _3DES
{
    partial class tripdes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputEncrypt = new System.Windows.Forms.TextBox();
            this.getKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yourKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.resultEncrypt = new System.Windows.Forms.TextBox();
            this.inputDecrypt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.resultDecrypt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.getEncrypt = new System.Windows.Forms.Button();
            this.getDecrypt = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.subKey1 = new System.Windows.Forms.TextBox();
            this.subKey2 = new System.Windows.Forms.TextBox();
            this.subKey3 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.radioCFB = new System.Windows.Forms.RadioButton();
            this.radioCBC = new System.Windows.Forms.RadioButton();
            this.radioECB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCTR = new System.Windows.Forms.RadioButton();
            this.radioOFB = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.yourIV = new System.Windows.Forms.TextBox();
            this.getIV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputEncrypt
            // 
            this.inputEncrypt.Location = new System.Drawing.Point(25, 186);
            this.inputEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.inputEncrypt.Name = "inputEncrypt";
            this.inputEncrypt.Size = new System.Drawing.Size(182, 23);
            this.inputEncrypt.TabIndex = 2;
            this.inputEncrypt.Text = "Enter plain text to hash";
            this.inputEncrypt.GotFocus += new System.EventHandler(this.inputEncrypt_gotFocus);
            this.inputEncrypt.LostFocus += new System.EventHandler(this.inputEncrypt_lostFocus);
            // 
            // getKey
            // 
            this.getKey.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getKey.Location = new System.Drawing.Point(1028, 46);
            this.getKey.Margin = new System.Windows.Forms.Padding(4);
            this.getKey.Name = "getKey";
            this.getKey.Size = new System.Drawing.Size(87, 28);
            this.getKey.TabIndex = 4;
            this.getKey.Text = "Get Key";
            this.getKey.UseVisualStyleBackColor = false;
            this.getKey.Click += new System.EventHandler(this.getKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Triple DES Encryption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Triple DES Decryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter text to be Encrypted";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter text to be Decrypted";
            // 
            // yourKey
            // 
            this.yourKey.Location = new System.Drawing.Point(799, 49);
            this.yourKey.Margin = new System.Windows.Forms.Padding(4);
            this.yourKey.Name = "yourKey";
            this.yourKey.Size = new System.Drawing.Size(207, 23);
            this.yourKey.TabIndex = 1;
            this.yourKey.Text = "Enter Key";
            this.yourKey.GotFocus += new System.EventHandler(this.yourKey_gotFocus);
            this.yourKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.yourKey_KeyDown);
            this.yourKey.LostFocus += new System.EventHandler(this.yourKey_lostFocus);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Triple DES Encrypted Output:";
            // 
            // resultEncrypt
            // 
            this.resultEncrypt.Location = new System.Drawing.Point(25, 314);
            this.resultEncrypt.Name = "resultEncrypt";
            this.resultEncrypt.Size = new System.Drawing.Size(182, 23);
            this.resultEncrypt.TabIndex = 19;
            // 
            // inputDecrypt
            // 
            this.inputDecrypt.Location = new System.Drawing.Point(380, 186);
            this.inputDecrypt.Name = "inputDecrypt";
            this.inputDecrypt.Size = new System.Drawing.Size(202, 23);
            this.inputDecrypt.TabIndex = 20;
            this.inputDecrypt.Text = "Enter text to Decrypt";
            this.inputDecrypt.GotFocus += new System.EventHandler(this.inputDecrypt_gotFocus);
            this.inputDecrypt.LostFocus += new System.EventHandler(this.inputDecrypt_lostFocus);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(382, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Triple DES Decrypted Output :";
            // 
            // resultDecrypt
            // 
            this.resultDecrypt.Location = new System.Drawing.Point(380, 316);
            this.resultDecrypt.Name = "resultDecrypt";
            this.resultDecrypt.Size = new System.Drawing.Size(201, 23);
            this.resultDecrypt.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(796, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 17);
            this.label16.TabIndex = 31;
            this.label16.Text = "Your Key:";
            // 
            // getEncrypt
            // 
            this.getEncrypt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getEncrypt.Location = new System.Drawing.Point(25, 227);
            this.getEncrypt.Name = "getEncrypt";
            this.getEncrypt.Size = new System.Drawing.Size(79, 34);
            this.getEncrypt.TabIndex = 32;
            this.getEncrypt.Text = "Encrypt";
            this.getEncrypt.UseVisualStyleBackColor = false;
            this.getEncrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // getDecrypt
            // 
            this.getDecrypt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getDecrypt.Location = new System.Drawing.Point(380, 226);
            this.getDecrypt.Name = "getDecrypt";
            this.getDecrypt.Size = new System.Drawing.Size(90, 37);
            this.getDecrypt.TabIndex = 33;
            this.getDecrypt.Text = "Decrypt";
            this.getDecrypt.UseVisualStyleBackColor = false;
            this.getDecrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Refresh.Location = new System.Drawing.Point(537, 404);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(90, 37);
            this.Refresh.TabIndex = 35;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // subKey1
            // 
            this.subKey1.Location = new System.Drawing.Point(24, 49);
            this.subKey1.Name = "subKey1";
            this.subKey1.Size = new System.Drawing.Size(182, 23);
            this.subKey1.TabIndex = 36;
            // 
            // subKey2
            // 
            this.subKey2.Location = new System.Drawing.Point(254, 49);
            this.subKey2.Name = "subKey2";
            this.subKey2.Size = new System.Drawing.Size(182, 23);
            this.subKey2.TabIndex = 37;
            // 
            // subKey3
            // 
            this.subKey3.Location = new System.Drawing.Point(483, 49);
            this.subKey3.Name = "subKey3";
            this.subKey3.Size = new System.Drawing.Size(182, 23);
            this.subKey3.TabIndex = 38;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(172, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 21);
            this.radioButton1.TabIndex = 41;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "3 keys";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(254, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 21);
            this.radioButton2.TabIndex = 42;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2 keys";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(363, 12);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 21);
            this.radioButton3.TabIndex = 43;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "1 key";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Choose key mode:";
            // 
            // radioCFB
            // 
            this.radioCFB.AutoSize = true;
            this.radioCFB.Location = new System.Drawing.Point(175, 45);
            this.radioCFB.Name = "radioCFB";
            this.radioCFB.Size = new System.Drawing.Size(52, 21);
            this.radioCFB.TabIndex = 48;
            this.radioCFB.TabStop = true;
            this.radioCFB.Text = "CFB";
            this.radioCFB.UseVisualStyleBackColor = true;
            this.radioCFB.CheckedChanged += new System.EventHandler(this.radioCFB_CheckedChanged);
            // 
            // radioCBC
            // 
            this.radioCBC.AutoSize = true;
            this.radioCBC.Location = new System.Drawing.Point(90, 45);
            this.radioCBC.Name = "radioCBC";
            this.radioCBC.Size = new System.Drawing.Size(53, 21);
            this.radioCBC.TabIndex = 47;
            this.radioCBC.TabStop = true;
            this.radioCBC.Text = "CBC";
            this.radioCBC.UseVisualStyleBackColor = true;
            this.radioCBC.CheckedChanged += new System.EventHandler(this.radioCBC_CheckedChanged);
            // 
            // radioECB
            // 
            this.radioECB.AutoSize = true;
            this.radioECB.Checked = true;
            this.radioECB.Location = new System.Drawing.Point(6, 45);
            this.radioECB.Name = "radioECB";
            this.radioECB.Size = new System.Drawing.Size(53, 21);
            this.radioECB.TabIndex = 46;
            this.radioECB.TabStop = true;
            this.radioECB.Text = "ECB";
            this.radioECB.UseVisualStyleBackColor = true;
            this.radioECB.CheckedChanged += new System.EventHandler(this.radioECB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCTR);
            this.groupBox1.Controls.Add(this.radioOFB);
            this.groupBox1.Controls.Add(this.radioECB);
            this.groupBox1.Controls.Add(this.radioCFB);
            this.groupBox1.Controls.Add(this.radioCBC);
            this.groupBox1.Location = new System.Drawing.Point(799, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 100);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose mode";
            // 
            // radioCTR
            // 
            this.radioCTR.AutoSize = true;
            this.radioCTR.Location = new System.Drawing.Point(319, 45);
            this.radioCTR.Name = "radioCTR";
            this.radioCTR.Size = new System.Drawing.Size(54, 21);
            this.radioCTR.TabIndex = 50;
            this.radioCTR.TabStop = true;
            this.radioCTR.Text = "CTR";
            this.radioCTR.UseVisualStyleBackColor = true;
            this.radioCTR.CheckedChanged += new System.EventHandler(this.radioCTR_CheckedChanged);
            // 
            // radioOFB
            // 
            this.radioOFB.AutoSize = true;
            this.radioOFB.Location = new System.Drawing.Point(249, 45);
            this.radioOFB.Name = "radioOFB";
            this.radioOFB.Size = new System.Drawing.Size(54, 21);
            this.radioOFB.TabIndex = 49;
            this.radioOFB.TabStop = true;
            this.radioOFB.Text = "OFB";
            this.radioOFB.UseVisualStyleBackColor = true;
            this.radioOFB.CheckedChanged += new System.EventHandler(this.radioOFB_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(796, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "Your IV:";
            // 
            // yourIV
            // 
            this.yourIV.Location = new System.Drawing.Point(799, 314);
            this.yourIV.Margin = new System.Windows.Forms.Padding(4);
            this.yourIV.Name = "yourIV";
            this.yourIV.Size = new System.Drawing.Size(207, 23);
            this.yourIV.TabIndex = 54;
            // 
            // getIV
            // 
            this.getIV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getIV.Location = new System.Drawing.Point(1028, 311);
            this.getIV.Margin = new System.Windows.Forms.Padding(4);
            this.getIV.Name = "getIV";
            this.getIV.Size = new System.Drawing.Size(87, 28);
            this.getIV.TabIndex = 53;
            this.getIV.Text = "Get IV";
            this.getIV.UseVisualStyleBackColor = false;
            this.getIV.Click += new System.EventHandler(this.getIV_Click);
            // 
            // tripdes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 582);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.yourIV);
            this.Controls.Add(this.getIV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.subKey3);
            this.Controls.Add(this.subKey2);
            this.Controls.Add(this.subKey1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.getDecrypt);
            this.Controls.Add(this.getEncrypt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.resultDecrypt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.inputDecrypt);
            this.Controls.Add(this.resultEncrypt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.yourKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getKey);
            this.Controls.Add(this.inputEncrypt);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tripdes";
            this.Text = "3DES";
            this.Load += new System.EventHandler(this.tripdes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputEncrypt;
        private System.Windows.Forms.Button getKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yourKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox resultEncrypt;
        private System.Windows.Forms.TextBox inputDecrypt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox resultDecrypt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button getEncrypt;
        private System.Windows.Forms.Button getDecrypt;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.TextBox subKey1;
        private System.Windows.Forms.TextBox subKey2;
        private System.Windows.Forms.TextBox subKey3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioCFB;
        private System.Windows.Forms.RadioButton radioCBC;
        private System.Windows.Forms.RadioButton radioECB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox yourIV;
        private System.Windows.Forms.Button getIV;
        private System.Windows.Forms.RadioButton radioOFB;
        private System.Windows.Forms.RadioButton radioCTR;
    }
}

