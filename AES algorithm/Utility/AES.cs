using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AES_algorithm.Utility
{   
    //Interface Class For AES Algorithm
    interface IAES
    {
        string encryptText(string text, string key);
        string decryptText(string text, string key);

    }
}
