
using System.Text;
using System.Security.Cryptography;
using Encrypt_Me.model;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using System;

namespace Encrypt_Me.services
{
    internal class EncryptionService
    {
        String secretKeyForUserData = "eRMgmVN7lVsQwC6PomyWYyAwir7PXrEp11kd7WWMbtzX2qOoOu171p2rdUhCmyRK2FAMu6vukzTK2ORpSpTkhFpKirGswnWeOVE";
        public EncryptionService() {  }

        public ResultModel encryptToSHA256(string text, string secretKey)
        {
            /*
                Hashing text to SHA256
                *** Keep in mind that the hash itself is not directly reversible, as it's a one-way function. ***
                
                1. Combine text with secretkey
                2. convert text+secretKey -> UTF encoding -> bytes of UTF 8
                3. Use Cryptography (SHA 256) to hash the UTF8 bytes  
                4. Convert each byte to a 2-digit hexadecimal representation
                5. return result
             */



            // 1. Combine text with secretkey
            string textToEncrypt = text + secretKey;
            Debug.WriteLine(textToEncrypt);
            ResultModel result = new ResultModel(textToEncrypt);

            // 2.convert text + secretKey->UTF encoding->bytes
            byte[] bytesOfUTF8 = Encoding.UTF8.GetBytes(textToEncrypt);
            result.setUTF8InBytes(bytesOfUTF8);

            // 2.1 get the UTF 8 , to show the encoding result
            string utf8 = Encoding.UTF8.GetString(bytesOfUTF8);
            result.setUTF8(utf8);


            // 3.Use Cryptography (SHA 256) to hash the UTF8 bytes  
            using SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(bytesOfUTF8);


            // 4.Convert each byte to a 2-digit hexadecimal representation 
            result.setEncrypted256Data(bytes);
             
            // 5. return result to show 
            result.setBinaryBeforeHashString(textToEncrypt);
            result.setBinaryAfterHashString(bytes);
            result.setTotalBit(textToEncrypt);
            return result; 
        } 

        public string getSecretKeyUserData()
        {
            return secretKeyForUserData;
        }
    }
}
