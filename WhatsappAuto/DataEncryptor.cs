using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WhatsappAuto.Properties;

namespace WhatsappAuto
{
    internal class DataEncryptor
    {

        static string key = Settings.Default.EncryptionKey; 
        private static readonly byte[] Salt = Encoding.UTF8.GetBytes("WASaltValue");
        private static readonly int Iterations = 1000;

        public string Encryptor(string plaintext)
        {
            byte[] keyBytes = new Rfc2898DeriveBytes(key, Salt, Iterations).GetBytes(32);
            byte[] iv = new byte[16];
            byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = iv;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(plaintextBytes, 0, plaintextBytes.Length);
                    }

                    byte[] ciphertextBytes = ms.ToArray();
                    return Convert.ToBase64String(ciphertextBytes) + "\n";
                }
            }
        }

        public string Decryptor(string ciphertext)
        {
            byte[] keyBytes = new Rfc2898DeriveBytes(key, Salt, Iterations).GetBytes(32);
            byte[] iv = new byte[16];
            byte[] ciphertextBytes = Convert.FromBase64String(ciphertext);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = iv;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(ciphertextBytes, 0, ciphertextBytes.Length);
                    }

                    byte[] plaintextBytes = ms.ToArray();
                    return Encoding.UTF8.GetString(plaintextBytes);
                }
            }
        }
    }
}

