namespace RSAFrom
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateKey = new System.Windows.Forms.Button();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtEncryptText = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtDecryptText = new System.Windows.Forms.TextBox();
            this.txtPublicKeyLen = new System.Windows.Forms.TextBox();
            this.txtPrivateKeyLen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTextLen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEncryptTextLen = new System.Windows.Forms.TextBox();
            this.btnServiceEncrypt = new System.Windows.Forms.Button();
            this.btnServiceDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateKey
            // 
            this.btnCreateKey.Location = new System.Drawing.Point(312, 296);
            this.btnCreateKey.Name = "btnCreateKey";
            this.btnCreateKey.Size = new System.Drawing.Size(75, 23);
            this.btnCreateKey.TabIndex = 0;
            this.btnCreateKey.Text = "生成密钥";
            this.btnCreateKey.UseVisualStyleBackColor = true;
            this.btnCreateKey.Click += new System.EventHandler(this.btnCreateKey_Click);
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(50, 13);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.ReadOnly = true;
            this.txtPublicKey.Size = new System.Drawing.Size(621, 56);
            this.txtPublicKey.TabIndex = 1;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(49, 83);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ReadOnly = true;
            this.txtPrivateKey.Size = new System.Drawing.Size(621, 194);
            this.txtPrivateKey.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "公钥：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "密钥：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "文本：";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(50, 340);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(621, 74);
            this.txtText.TabIndex = 6;
            // 
            // txtEncryptText
            // 
            this.txtEncryptText.Location = new System.Drawing.Point(50, 449);
            this.txtEncryptText.Multiline = true;
            this.txtEncryptText.Name = "txtEncryptText";
            this.txtEncryptText.Size = new System.Drawing.Size(620, 85);
            this.txtEncryptText.TabIndex = 7;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(312, 420);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 8;
            this.btnEncrypt.Text = "加密";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(312, 540);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "解密";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtDecryptText
            // 
            this.txtDecryptText.Location = new System.Drawing.Point(50, 569);
            this.txtDecryptText.Multiline = true;
            this.txtDecryptText.Name = "txtDecryptText";
            this.txtDecryptText.Size = new System.Drawing.Size(620, 77);
            this.txtDecryptText.TabIndex = 10;
            // 
            // txtPublicKeyLen
            // 
            this.txtPublicKeyLen.Location = new System.Drawing.Point(74, 298);
            this.txtPublicKeyLen.Name = "txtPublicKeyLen";
            this.txtPublicKeyLen.Size = new System.Drawing.Size(166, 21);
            this.txtPublicKeyLen.TabIndex = 11;
            // 
            // txtPrivateKeyLen
            // 
            this.txtPrivateKeyLen.Location = new System.Drawing.Point(504, 296);
            this.txtPrivateKeyLen.Name = "txtPrivateKeyLen";
            this.txtPrivateKeyLen.Size = new System.Drawing.Size(159, 21);
            this.txtPrivateKeyLen.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "公钥长度：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "私钥长度：";
            // 
            // txtTextLen
            // 
            this.txtTextLen.Location = new System.Drawing.Point(118, 422);
            this.txtTextLen.Name = "txtTextLen";
            this.txtTextLen.Size = new System.Drawing.Size(100, 21);
            this.txtTextLen.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "文本长度：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 542);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "密文长度：";
            // 
            // txtEncryptTextLen
            // 
            this.txtEncryptTextLen.Location = new System.Drawing.Point(118, 540);
            this.txtEncryptTextLen.Name = "txtEncryptTextLen";
            this.txtEncryptTextLen.Size = new System.Drawing.Size(100, 21);
            this.txtEncryptTextLen.TabIndex = 18;
            // 
            // btnServiceEncrypt
            // 
            this.btnServiceEncrypt.Location = new System.Drawing.Point(445, 420);
            this.btnServiceEncrypt.Name = "btnServiceEncrypt";
            this.btnServiceEncrypt.Size = new System.Drawing.Size(89, 23);
            this.btnServiceEncrypt.TabIndex = 19;
            this.btnServiceEncrypt.Text = "调用服务加密";
            this.btnServiceEncrypt.UseVisualStyleBackColor = true;
            this.btnServiceEncrypt.Click += new System.EventHandler(this.btnServiceEncrypt_Click);
            // 
            // btnServiceDecrypt
            // 
            this.btnServiceDecrypt.Location = new System.Drawing.Point(445, 540);
            this.btnServiceDecrypt.Name = "btnServiceDecrypt";
            this.btnServiceDecrypt.Size = new System.Drawing.Size(89, 23);
            this.btnServiceDecrypt.TabIndex = 20;
            this.btnServiceDecrypt.Text = "调用服务解密";
            this.btnServiceDecrypt.UseVisualStyleBackColor = true;
            this.btnServiceDecrypt.Click += new System.EventHandler(this.btnServiceDecrypt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 658);
            this.Controls.Add(this.btnServiceDecrypt);
            this.Controls.Add(this.btnServiceEncrypt);
            this.Controls.Add(this.txtEncryptTextLen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTextLen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrivateKeyLen);
            this.Controls.Add(this.txtPublicKeyLen);
            this.Controls.Add(this.txtDecryptText);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtEncryptText);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.btnCreateKey);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateKey;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtEncryptText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtDecryptText;
        private System.Windows.Forms.TextBox txtPublicKeyLen;
        private System.Windows.Forms.TextBox txtPrivateKeyLen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTextLen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEncryptTextLen;
        private System.Windows.Forms.Button btnServiceEncrypt;
        private System.Windows.Forms.Button btnServiceDecrypt;
    }
}

