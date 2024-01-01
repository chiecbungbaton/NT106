using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;

namespace Lab6
{
    internal class RSA
    {
        public static RSACryptoServiceProvider ImportPublicKey(RSACryptoServiceProvider csp)
        {
            //lấy đường thư mục clent
            var currentDirectory = Directory.GetCurrentDirectory();
            var basePath = currentDirectory.Split(new string[] { "\\bin" }, StringSplitOptions.None)[0];
            //Lấy đường dẫn key
            string keyPath = basePath + "\\keyRSA\\public_Key.pem";
            string pem = File.ReadAllText(keyPath);
            PemReader pr = new PemReader(new StringReader(pem));
            AsymmetricKeyParameter publicKey = (AsymmetricKeyParameter)pr.ReadObject();
            RSAParameters rsaParams = DotNetUtilities.ToRSAParameters((RsaKeyParameters)publicKey);

            csp.ImportParameters(rsaParams);
            return csp;
        }
        public static byte[] EncryptData(string data)
        {
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            byte[] dataBytes = new byte[2048 * 32];
            dataBytes = Encoding.UTF8.GetBytes(data);
            csp = ImportPublicKey(csp);
            // Mã hóa dữ liệu bằng khóa công khai RSA
            byte[] encryptedDataBytes = csp.Encrypt(dataBytes, false);
            return encryptedDataBytes;
        }
        public static RSACryptoServiceProvider ImportPrivateKey(RSACryptoServiceProvider csp)
        {
            //lấy đường dẫn thư mục server
            var currentDirectory = Directory.GetCurrentDirectory();
            var basePath = currentDirectory.Split(new string[] { "\\bin" }, StringSplitOptions.None)[0];
            //Lấy đường dẫn key
            string keyPath = basePath + "\\keyRSA\\private_key.pem";
            string pem = File.ReadAllText(keyPath);
            PemReader pr = new PemReader(new StringReader(pem));
            AsymmetricCipherKeyPair KeyPair = (AsymmetricCipherKeyPair)pr.ReadObject();
            RSAParameters rsaParams = DotNetUtilities.ToRSAParameters((RsaPrivateCrtKeyParameters)KeyPair.Private);
            csp.ImportParameters(rsaParams);
            return csp;
        }
        public static string DecryptData(byte[] encryptedDataBytes)
        {
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            // Giải mã dữ liệu bằng khóa bí mật RSA
            csp = ImportPrivateKey(csp);
            byte[] decryptedDataBytes = csp.Decrypt(encryptedDataBytes, false);
            string plainText = Encoding.UTF8.GetString(decryptedDataBytes);
            return plainText;
        }
    }
}
