using System;
using System.IO;
using System.Security.Cryptography;

namespace RaceWinFormsApp
{
    public static class AESEncryptionProvider
    {
        private static string keysPath = @"aesKeys.dat";

        /// <summary>
        /// Encrypt string via AES algorithm
        /// </summary>
        public static string EncryptString(string originalString)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = GetKeys(out var aesIV);
                aes.IV = aesIV;
                var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                
                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(originalString);
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }
        /// <summary>
        /// Decrypt string via AES algorithm
        /// </summary>
        public static string DecryptString(string decryptedString)
        {
            var cipherText = Convert.FromBase64String(decryptedString);
            using (var aes = Aes.Create())
            {
                aes.Key = GetKeys(out var aesIV);
                aes.IV = aesIV;
                var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (var msDecrypt = new MemoryStream(cipherText))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var reader = new StreamReader(csDecrypt))
                {
                    return reader.ReadToEnd();
                }
            }
        }
        /// <summary>
        /// Get AES keys
        /// </summary>
        private static byte[] GetKeys(out byte[] aesIV)
        {
            byte[] aesKey;

            if (!File.Exists(keysPath))
            {
                using (var aes = Aes.Create())
                {
                    aes.GenerateKey();
                    aes.GenerateIV();

                    aesKey = aes.Key;
                    aesIV = aes.IV;

                    FileProvider.Save(keysPath, $"{Convert.ToBase64String(aesKey)}\n{Convert.ToBase64String(aesIV)}");
                }
                return aesKey;
            }

            var aesFile = FileProvider.GetContent(keysPath).Split("\n");

            aesKey = Convert.FromBase64String(aesFile[0]);
            aesIV = Convert.FromBase64String(aesFile[1]);            
            return aesKey;
        }
    }
}
