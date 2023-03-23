using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AES_algorithm.Utility
{
    //ECB Mode
    public class ECBMode : IAES
    {
        public string encryptText(string text, string key)
        {
            byte[] src = Encoding.UTF8.GetBytes(text);
            byte[] bKey = Encoding.ASCII.GetBytes(key);
            RijndaelManaged aes = new RijndaelManaged();
            aes.Mode = CipherMode.ECB;
            aes.Padding = PaddingMode.PKCS7;
            aes.KeySize = 128;

            using (ICryptoTransform encrypt = aes.CreateEncryptor(bKey, null))
            {
                byte[] dest = encrypt.TransformFinalBlock(src, 0, src.Length);
                encrypt.Dispose();
                return Convert.ToBase64String(dest);
            }
        }

        public string decryptText(string text, string key)
        {
            byte[] src = Convert.FromBase64String(text);
            RijndaelManaged aes = new RijndaelManaged();
            byte[] bKey = Encoding.ASCII.GetBytes(key);
            aes.KeySize = 128;
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.ECB;
            using (ICryptoTransform decrypt = aes.CreateDecryptor(bKey, null))
            {
                byte[] dest = decrypt.TransformFinalBlock(src, 0, src.Length);
                decrypt.Dispose();
                return Encoding.UTF8.GetString(dest);
            }
        }
    }
}
