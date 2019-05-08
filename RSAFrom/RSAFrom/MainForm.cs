using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;

namespace RSAFrom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string publicKey = "<RSAKeyValue><Modulus>n3vDWKOByagHq3xjvubrdSly2QcT9a4hKDBOlWb71h2EtLPMa1OoSP5An1HQow9S6Jc1ZGwxB1yVW/NEVUjB7V4YDASNz4RfGTaSCQwNbHADfow9NsDibKnXtcjD9q3ye7EXklBAgPN9WUDdjO15c8m9+AfzHjZSadh4dGTyj1U=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
            string privateKey = "<RSAKeyValue><Modulus>n3vDWKOByagHq3xjvubrdSly2QcT9a4hKDBOlWb71h2EtLPMa1OoSP5An1HQow9S6Jc1ZGwxB1yVW/NEVUjB7V4YDASNz4RfGTaSCQwNbHADfow9NsDibKnXtcjD9q3ye7EXklBAgPN9WUDdjO15c8m9+AfzHjZSadh4dGTyj1U=</Modulus><Exponent>AQAB</Exponent><P>z+7PiCHEPc6ShUjdTjwJB6Vsg6wPGGrMeIi9XhfPZKqbm0vWemKkQ6xb9/Fmjy7hR7KJ/xsG4OBT0O2NBoa66Q==</P><Q>xFnH+rJCzubjlwIacTrzmN2JeJo1fIVKgxZTUlIkIgu3mqsZJ/0jTamMSaOyvg0XBYGj8BLnjdWrnXVSMdSVjQ==</Q><DP>nqJ0JEiWngzOTe9UH46/2NyE2EPZVGiOTFsOFg4WRJfAlY8bN02wQozpsVSzSQOcDYYRr9WfvsqGR3wkPlllmQ==</DP><DQ>tyc4TzUw9GaTLS0dFTn0OEeOEB1ofvqmgpi0qDlO0yMy5Ods08xgvfTFk3tLI9R6APzouuwnajpBluL1BN5TkQ==</DQ><InverseQ>Nebhvat9V0yo2E769FG2+kP11rzZd+YdsQtLKMsIzPxq0/FteUx8oPz02ti0OLtTSxegjqzE/BcYfND4vzZxuQ==</InverseQ><D>ZHEy75FSvWlpIzSdMW8H3esz3MGbbYC0ezYpV+jbNNe0a4ZNeU7fztDqbCy/5OJSyg/pXYzSOBu0KYwFflzrXQ/l6y+EjV/n48Q5/AgrOtIJ1ngtBApvfkzSeg/jKNc+CRS60hoGTVsnEgCFZeUGs84UjcaZ8eSae17CpwfFXaE=</D></RSAKeyValue>";
            txtPublicKey.Text = publicKey;
            txtPrivateKey.Text = privateKey;
            txtPublicKeyLen.Text = publicKey.Length.ToString();
            txtPrivateKeyLen.Text = privateKey.Length.ToString();
        }

        private void btnCreateKey_Click(object sender, EventArgs e)
        {            
            RSAKey rsakey = RSAHelper.GenerateKey();
            txtPublicKey.Text = rsakey.PublicKey;
            txtPrivateKey.Text = rsakey.PrivateKey;
            txtPublicKeyLen.Text = rsakey.PublicKey.Length.ToString();
            txtPrivateKeyLen.Text = rsakey.PrivateKey.Length.ToString();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtEncryptText.Text = RSAHelper.RSAEncrypt(txtText.Text, txtPublicKey.Text);
            txtTextLen.Text = txtText.Text.Length.ToString();
            txtEncryptTextLen.Text = txtEncryptText.Text.Length.ToString();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtDecryptText.Text = RSAHelper.RSADecrypt(txtEncryptText.Text, txtPrivateKey.Text);
        }

        /// <summary>
        /// 调用服务加密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnServiceEncrypt_Click(object sender, EventArgs e)
        {
            //H5Service.H5ServiceSoapClient service = new H5Service.H5ServiceSoapClient();

            //txtEncryptText.Text = service.Encrypt(txtText.Text);
            //txtTextLen.Text = txtText.Text.Length.ToString();
            //txtEncryptTextLen.Text = txtEncryptText.Text.Length.ToString();
        }

        /// <summary>
        /// 调用服务解密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnServiceDecrypt_Click(object sender, EventArgs e)
        {
            //H5Service.H5ServiceSoapClient service = new H5Service.H5ServiceSoapClient();
            //txtDecryptText.Text = service.Decrypt("", "", txtEncryptText.Text);
        }
    }
}
