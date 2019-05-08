using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace RSAFrom
{
    public class RSAHelper
    {
        public static RSAKey GenerateKey()
        {
            RSAKey rsakey = new RSAKey();
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            rsakey.PublicKey = RSA.ToXmlString(false);
            rsakey.PrivateKey = RSA.ToXmlString(true);
            RSA.Clear();
            return rsakey;
        }

        #region 加密
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataToEncrypt">最多117个字节</param>
        /// <param name="publicKey"></param>
        /// <returns>256个字节的长度</returns>
        public static string RSAEncrypt(string dataToEncrypt, string publicKey)
        {
            Encoding encoder = Encoding.UTF8;
            byte[] encryptData = encoder.GetBytes(dataToEncrypt);
            return RSAEncrypt(encryptData, publicKey);
        }

        public static string RSAEncrypt(byte[] dataToEncrypt,string publicKey)
        {
            using(RSACryptoServiceProvider RSA= CreateEncryptRSA(publicKey))
            {
                byte[] encryptedDate = RSA.Encrypt(dataToEncrypt, false);
                return BytesToHexString(encryptedDate);
            }
        }
        #endregion

        #region 解密
        public static string RSADecrypt(string encryptedDate, string privateKey)
        {
            using(RSACryptoServiceProvider RSA= CreateDecryptRSA(privateKey))
            {
                Encoding encoder = Encoding.UTF8;
                byte[] _encyptedData = HexStringToBytes(encryptedDate);
                byte[] decryptData = RSA.Decrypt(_encyptedData, false);
                return encoder.GetString(decryptData);
            }
        }
        #endregion

        #region 创建加解密RSA

        /// <summary>
        /// 创建加密RSA
        /// </summary>
        /// <param name="publicKey">公钥</param>
        /// <returns></returns>
        private static RSACryptoServiceProvider CreateEncryptRSA(string publicKey)
        {
            try
            {
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                RSA.FromXmlString(publicKey);
                return RSA;
            }
            catch (CryptographicException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 创建解密RSA
        /// </summary>
        /// <param name="privateKey">私钥</param>
        /// <returns></returns>
        private static RSACryptoServiceProvider CreateDecryptRSA(string privateKey)
        {
            try
            {
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                RSA.FromXmlString(privateKey);
                return RSA;
            }
            catch (CryptographicException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 根据安全证书创建加密RSA
        /// </summary>
        /// <param name="certfile">公钥文件</param>
        /// <returns></returns>
        private RSACryptoServiceProvider X509CertCreateEncryptRSA(string certfile)
        {
            try
            {
                X509Certificate2 x509Cert = new X509Certificate2(certfile);
                RSACryptoServiceProvider RSA = (RSACryptoServiceProvider)x509Cert.PublicKey.Key;
                return RSA;
            }
            catch (CryptographicException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 根据私钥文件创建解密RSA
        /// </summary>
        /// <param name="keyfile">私钥文件</param>
        /// <param name="password">访问含私钥文件的密码</param>
        /// <returns></returns>
        private RSACryptoServiceProvider X509CertCreateDecryptRSA(string keyfile, string password)
        {
            try
            {
                X509Certificate2 x509Cert = new X509Certificate2(keyfile, password);
                RSACryptoServiceProvider RSA = (RSACryptoServiceProvider)x509Cert.PrivateKey;
                return RSA;
            }
            catch (CryptographicException ex)
            {
                throw ex;
            }
        }

        #endregion

        #region 数据转换

        /// <summary>
        /// Bytes to string
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static string BytesToHexString(byte[] parameters)
        {
            StringBuilder hexString = new StringBuilder(64);
            for (int i = 0; i < parameters.Length; i++)
            {
                hexString.Append(String.Format("{0:x2}", parameters[i]));
            }
            return hexString.ToString();
        }
        /// <summary>
        /// string to Bytes
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static byte[] HexStringToBytes(string hex)
        {
            if (hex.Length == 0)
            {
                return new byte[] { 0 };
            }

            if (hex.Length % 2 == 1)
            {
                hex = "0" + hex;
            }

            byte[] result = new byte[hex.Length / 2];

            for (int i = 0; i < hex.Length / 2; i++)
            {
                result[i] = byte.Parse(hex.Substring(2 * i, 2), System.Globalization.NumberStyles.HexNumber);
            }
            return result;
        }

        #endregion
    }
}
