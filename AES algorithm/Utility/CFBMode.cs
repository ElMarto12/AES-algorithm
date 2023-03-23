﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AES_algorithm.Utility
{
    //CFB Mode
    public class CFBMode : IAES
    {
        byte[] initVector = Encoding.ASCII.GetBytes("jsKidmshatyb4jdu");
        public string encryptText(string text, string key) 
        {
            byte[] bKey = Encoding.ASCII.GetBytes(key);

            try
            {
                using (var rijndaelManaged = new RijndaelManaged { Key = bKey, IV = initVector, Mode = CipherMode.CFB })
                using (var memoryStream = new MemoryStream())
                using (var cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(bKey, initVector), CryptoStreamMode.Write))
                {
                    using (var ws = new StreamWriter(cryptoStream))
                    {
                        ws.Write(text);
                    }
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            catch (CryptographicException e)
            {
                MessageBox.Show("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }

        public string decryptText(string text, string key){

            byte[] bKey = Encoding.ASCII.GetBytes(key);

            try
            {
                using (var rijndaelManaged = new RijndaelManaged { Key = bKey, IV = initVector, Mode = CipherMode.CFB })
                using (var memoryStream = new MemoryStream(Convert.FromBase64String(text)))
                using (var cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(bKey, initVector), CryptoStreamMode.Read))
                {
                    return new StreamReader(cryptoStream).ReadToEnd();
                }
            }
            catch (CryptographicException e)
            {
                MessageBox.Show("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }
    }

}
