namespace _3DES
{
    partial class Test_3DES
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
            this.encryptBox = new System.Windows.Forms.TextBox();
            this.decryptBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.Label();
            this.yourKey = new System.Windows.Forms.Label();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.keyButton = new System.Windows.Forms.Button();
            this.getDecrypt = new System.Windows.Forms.Button();
            this.getEncrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encryptBox
            // 
            this.encryptBox.Location = new System.Drawing.Point(69, 142);
            this.encryptBox.Name = "encryptBox";
            this.encryptBox.Size = new System.Drawing.Size(100, 20);
            this.encryptBox.TabIndex = 1;
            // 
            // decryptBox
            // 
            this.decryptBox.Location = new System.Drawing.Point(402, 142);
            this.decryptBox.Name = "decryptBox";
            this.decryptBox.Size = new System.Drawing.Size(100, 20);
            this.decryptBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encrypt";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(69, 29);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 20);
            this.inputBox.TabIndex = 4;
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(66, 1);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(31, 13);
            this.Input.TabIndex = 5;
            this.Input.Text = "Input";
            // 
            // yourKey
            // 
            this.yourKey.AutoSize = true;
            this.yourKey.Location = new System.Drawing.Point(399, 1);
            this.yourKey.Name = "yourKey";
            this.yourKey.Size = new System.Drawing.Size(47, 13);
            this.yourKey.TabIndex = 7;
            this.yourKey.Text = "YourKey";
            // 
            // keyInput
            // 
            this.keyInput.Location = new System.Drawing.Point(402, 29);
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(100, 20);
            this.keyInput.TabIndex = 6;
            // 
            // keyButton
            // 
            this.keyButton.Location = new System.Drawing.Point(527, 29);
            this.keyButton.Name = "keyButton";
            this.keyButton.Size = new System.Drawing.Size(75, 23);
            this.keyButton.TabIndex = 8;
            this.keyButton.Text = "getKey";
            this.keyButton.UseVisualStyleBackColor = true;
            this.keyButton.Click += new System.EventHandler(this.keyButton_Click);
            // 
            // getDecrypt
            // 
            this.getDecrypt.Location = new System.Drawing.Point(527, 139);
            this.getDecrypt.Name = "getDecrypt";
            this.getDecrypt.Size = new System.Drawing.Size(75, 23);
            this.getDecrypt.TabIndex = 9;
            this.getDecrypt.Text = "Decrypt";
            this.getDecrypt.UseVisualStyleBackColor = true;
            this.getDecrypt.Click += new System.EventHandler(this.getDecrypt_Click);
            // 
            // getEncrypt
            // 
            this.getEncrypt.Location = new System.Drawing.Point(189, 142);
            this.getEncrypt.Name = "getEncrypt";
            this.getEncrypt.Size = new System.Drawing.Size(75, 23);
            this.getEncrypt.TabIndex = 10;
            this.getEncrypt.Text = "Encrypt";
            this.getEncrypt.UseVisualStyleBackColor = true;
            this.getEncrypt.Click += new System.EventHandler(this.getEncrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Decrypt";
            // 
            // Test_3DES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getEncrypt);
            this.Controls.Add(this.getDecrypt);
            this.Controls.Add(this.keyButton);
            this.Controls.Add(this.yourKey);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.decryptBox);
            this.Controls.Add(this.encryptBox);
            this.Controls.Add(this.label1);
            this.Name = "Test_3DES";
            this.Text = "Test_3DES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptBox;
        private System.Windows.Forms.TextBox decryptBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.Label yourKey;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.Button keyButton;
        private System.Windows.Forms.Button getDecrypt;
        private System.Windows.Forms.Button getEncrypt;
        private System.Windows.Forms.Label label3;
    }
}