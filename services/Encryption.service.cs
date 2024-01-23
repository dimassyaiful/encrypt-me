
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
        public EncryptionService() {  }

        public ResultModel encryptToSHA256(string text)
        {
            /*
                Hashing text to SHA256
                *** Keep in mind that the hash itself is not directly reversible, as it's a one-way function. ***
                
                1. convert text -> UTF encoding -> bytes of UTF 8
                3. Use Cryptography (SHA 256) to hash the UTF8 bytes  
                4. Convert each byte to a 2-digit hexadecimal representation
                5. return result
             */



            // 1. Combine text
            string textToEncrypt = text;
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
         
    }
}
