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
            this.SuspendLayout();
            // 
            // inputEncrypt
            // 
            this.inputEncrypt.Location = new System.Drawing.Point(151, 99);
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
            this.label9.Location = new System.Drawing.Point(148, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Triple DES Encrypted Output:";
            // 
            // resultEncrypt
            // 
            this.resultEncrypt.Location = new System.Drawing.Point(151, 227);
            this.resultEncrypt.Name = "resultEncrypt";
            this.resultEncrypt.Size = new System.Drawing.Size(182, 23);
            this.resultEncrypt.TabIndex = 19;
            // 
            // inputDecrypt
            // 
            this.inputDecrypt.Location = new System.Drawing.Point(506, 99);
            this.inputDecrypt.Name = "inputDecrypt";
            this.inputDecrypt.Size = new System.Drawing.Size(202, 23);
            this.inputDecrypt.TabIndex = 20;
            this.inputDecrypt.TextChanged += new System.EventHandler(this.inputDecrypt_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(508, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(258, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Triple DES Decrypted Output (Base64):";
            // 
            // resultDecrypt
            // 
            this.resultDecrypt.Location = new System.Drawing.Point(506, 229);
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
            this.getEncrypt.Location = new System.Drawing.Point(151, 140);
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
            this.getDecrypt.Location = new System.Drawing.Point(506, 139);
            this.getDecrypt.Name = "getDecrypt";
            this.getDecrypt.Size = new System.Drawing.Size(90, 37);
            this.getDecrypt.TabIndex = 33;
            this.getDecrypt.Text = "Decrypt";
            this.getDecrypt.UseVisualStyleBackColor = false;
            this.getDecrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

