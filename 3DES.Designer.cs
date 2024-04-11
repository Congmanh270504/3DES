﻿namespace _3DES
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
            this.SuspendLayout();
            // 
            // inputEncrypt
            // 
            this.inputEncrypt.Location = new System.Drawing.Point(151, 89);
            this.inputEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.inputEncrypt.Name = "inputEncrypt";
            this.inputEncrypt.Size = new System.Drawing.Size(182, 23);
            this.inputEncrypt.TabIndex = 2;
            // 
            // getKey
            // 
            this.getKey.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getKey.Location = new System.Drawing.Point(967, 61);
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
            this.label1.Location = new System.Drawing.Point(148, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Triple DES Encryption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 25);
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
            // yourKey
            // 
            this.yourKey.Location = new System.Drawing.Point(847, 30);
            this.yourKey.Margin = new System.Windows.Forms.Padding(4);
            this.yourKey.Name = "yourKey";
            this.yourKey.Size = new System.Drawing.Size(207, 23);
            this.yourKey.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Triple DES Encrypted Output:";
            // 
            // resultEncrypt
            // 
            this.resultEncrypt.Location = new System.Drawing.Point(151, 217);
            this.resultEncrypt.Name = "resultEncrypt";
            this.resultEncrypt.Size = new System.Drawing.Size(182, 23);
            this.resultEncrypt.TabIndex = 19;
            // 
            // inputDecrypt
            // 
            this.inputDecrypt.Location = new System.Drawing.Point(506, 89);
            this.inputDecrypt.Name = "inputDecrypt";
            this.inputDecrypt.Size = new System.Drawing.Size(202, 23);
            this.inputDecrypt.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(508, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Triple DES Decrypted Output :";
            // 
            // resultDecrypt
            // 
            this.resultDecrypt.Location = new System.Drawing.Point(506, 219);
            this.resultDecrypt.Name = "resultDecrypt";
            this.resultDecrypt.Size = new System.Drawing.Size(201, 23);
            this.resultDecrypt.TabIndex = 29;
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
            // getEncrypt
            // 
            this.getEncrypt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getEncrypt.Location = new System.Drawing.Point(151, 130);
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
            this.getDecrypt.Location = new System.Drawing.Point(506, 129);
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
            this.Refresh.Location = new System.Drawing.Point(964, 505);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(90, 37);
            this.Refresh.TabIndex = 35;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // subKey1
            // 
            this.subKey1.Location = new System.Drawing.Point(151, 328);
            this.subKey1.Name = "subKey1";
            this.subKey1.Size = new System.Drawing.Size(182, 23);
            this.subKey1.TabIndex = 36;
            // 
            // subKey2
            // 
            this.subKey2.Location = new System.Drawing.Point(414, 328);
            this.subKey2.Name = "subKey2";
            this.subKey2.Size = new System.Drawing.Size(182, 23);
            this.subKey2.TabIndex = 37;
            this.subKey2.TextChanged += new System.EventHandler(this.subKey2_TextChanged);
            // 
            // subKey3
            // 
            this.subKey3.Location = new System.Drawing.Point(667, 328);
            this.subKey3.Name = "subKey3";
            this.subKey3.Size = new System.Drawing.Size(182, 23);
            this.subKey3.TabIndex = 38;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(287, 282);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 21);
            this.radioButton1.TabIndex = 41;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "mode 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(393, 282);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 21);
            this.radioButton2.TabIndex = 42;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "mode 2 ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(523, 282);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 21);
            this.radioButton3.TabIndex = 43;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "mode 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Choose key mode:";
            // 
            // tripdes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tripdes";
            this.Text = "3DES";
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
    }
}

