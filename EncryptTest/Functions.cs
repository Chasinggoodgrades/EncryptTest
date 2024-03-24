using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;

namespace EncryptTest
{
    public class Functions
    {
        public static string EncryptString(string input, byte[] key)
        {

            byte[] encryptPW = EncryptStringToBytes_Aes(input, key);
            
            return Convert.ToBase64String(encryptPW);
        }

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key)
        {
            byte[] encrypted;
            byte[] IV = new byte[16];
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }

            return encrypted;
        }


        // Brute force the key with just encrypted text
        public static string FindKey(string encryptedText)
        {
            byte[] cipheredText = Convert.FromBase64String(encryptedText);

            for (int i = 0; i < 256; i++)
            {
                byte[] key = Encoding.UTF8.GetBytes(new string((char)i, 16));

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = key;
                    aesAlg.IV = new byte[16];

                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    try
                    {
                        using (MemoryStream msDecrypt = new MemoryStream(cipheredText))
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            srDecrypt.ReadToEnd();
                            // Success??? RETURN!??!?!
                            return Convert.ToBase64String(key);
                        }
                    }
                    catch (CryptographicException)
                    {
                        // Failed
                    }
                }
            }
            return null;
        }




        static byte[] GenerateRandomSecretKey()
        {
            byte[] data = new byte[16];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(data);
            }
            return data;
        }

        public static (string Key, byte[] ByteKey) GenerateKey()
        {
            byte[] byteKey = GenerateRandomSecretKey();
            string key = Convert.ToBase64String(byteKey);
            return (key, byteKey);
        }


        public static string DecryptString(string input)
        {
            // Decrypt the input string
            return input;
        }
        public static string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@$&";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 12)
                                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void SavePassword(string password)
        {
            // Save the password to a file
            FileStream fileStream = new FileStream("password.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            streamWriter.Write(password);
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
