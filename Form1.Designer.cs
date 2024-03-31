namespace _3DES
{
    partial class Form1
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
            this.Output = new System.Windows.Forms.TextBox();
            this.getKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.yourKey = new System.Windows.Forms.TextBox();
            this.enterKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.resultEncrypt = new System.Windows.Forms.TextBox();
            this.inputDecrypt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.resultDecrypt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputEncrypt
            // 
            this.inputEncrypt.Location = new System.Drawing.Point(151, 99);
            this.inputEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.inputEncrypt.Name = "inputEncrypt";
            this.inputEncrypt.Size = new System.Drawing.Size(182, 23);
            this.inputEncrypt.TabIndex = 2;
            this.inputEncrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(609, 491);
            this.Output.Margin = new System.Windows.Forms.Padding(4);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(215, 23);
            this.Output.TabIndex = 3;
            this.Output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // getKey
            // 
            this.getKey.Location = new System.Drawing.Point(967, 61);
            this.getKey.Margin = new System.Windows.Forms.Padding(4);
            this.getKey.Name = "getKey";
            this.getKey.Size = new System.Drawing.Size(87, 28);
            this.getKey.TabIndex = 4;
            this.getKey.Text = "getKey";
            this.getKey.UseVisualStyleBackColor = true;
            this.getKey.Click += new System.EventHandler(this.getKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Triple DES Online Encryption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Triple DES Online Decryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter text to be Encrypted";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter text to be Decrypted";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select Mode";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ECB",
            "CBC"});
            this.comboBox1.Location = new System.Drawing.Point(151, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "ECB";
            // 
            // yourKey
            // 
            this.yourKey.Location = new System.Drawing.Point(847, 30);
            this.yourKey.Margin = new System.Windows.Forms.Padding(4);
            this.yourKey.Name = "yourKey";
            this.yourKey.Size = new System.Drawing.Size(207, 23);
            this.yourKey.TabIndex = 11;
            this.yourKey.Text = "key";
            this.yourKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yourKey.TextChanged += new System.EventHandler(this.Key1_TextChanged);
            // 
            // enterKey
            // 
            this.enterKey.Location = new System.Drawing.Point(151, 267);
            this.enterKey.Margin = new System.Windows.Forms.Padding(4);
            this.enterKey.Name = "enterKey";
            this.enterKey.Size = new System.Drawing.Size(182, 23);
            this.enterKey.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Enter Secret Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Output Text Format:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(292, 306);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 21);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Base64";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Triple DES Encrypted Output:";
            // 
            // resultEncrypt
            // 
            this.resultEncrypt.Location = new System.Drawing.Point(151, 427);
            this.resultEncrypt.Name = "resultEncrypt";
            this.resultEncrypt.Size = new System.Drawing.Size(182, 23);
            this.resultEncrypt.TabIndex = 19;
            this.resultEncrypt.TextChanged += new System.EventHandler(this.resultEncrypt_TextChanged);
            // 
            // inputDecrypt
            // 
            this.inputDecrypt.Location = new System.Drawing.Point(506, 99);
            this.inputDecrypt.Name = "inputDecrypt";
            this.inputDecrypt.Size = new System.Drawing.Size(202, 23);
            this.inputDecrypt.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(503, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Input Text Format:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(634, 138);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 21);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Base64";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(498, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Enter Secret Key";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(501, 267);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 23);
            this.textBox3.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(498, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Select Mode";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ECB",
            "CBC"});
            this.comboBox2.Location = new System.Drawing.Point(609, 186);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.Text = "ECB";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(503, 390);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(258, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Triple DES Decrypted Output (Base64):";
            // 
            // resultDecrypt
            // 
            this.resultDecrypt.Location = new System.Drawing.Point(501, 427);
            this.resultDecrypt.Name = "resultDecrypt";
            this.resultDecrypt.Size = new System.Drawing.Size(201, 23);
            this.resultDecrypt.TabIndex = 29;
            this.resultDecrypt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(845, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 17);
            this.label16.TabIndex = 31;
            this.label16.Text = "YourKey:";
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(151, 340);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(79, 34);
            this.Encrypt.TabIndex = 32;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(501, 337);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(90, 37);
            this.Decrypt.TabIndex = 33;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(501, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Plain to Text";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.resultDecrypt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.inputDecrypt);
            this.Controls.Add(this.resultEncrypt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.enterKey);
            this.Controls.Add(this.yourKey);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getKey);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.inputEncrypt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputEncrypt;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button getKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox yourKey;
        private System.Windows.Forms.TextBox enterKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox resultEncrypt;
        private System.Windows.Forms.TextBox inputDecrypt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox resultDecrypt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Button button2;
    }
}

