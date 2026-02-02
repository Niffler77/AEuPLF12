using System.Security.Cryptography;
using System.Text;

namespace Decrpyt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes("SecretKey123!!!!");
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.ECB;

            Byte[] inputBytes = File.ReadAllBytes("C:\\Users\\Benjamin\\source\\repos\\AEuPLF12\\Decrpyt\\encrypted");
            var decrypted = AesDecrypt(inputBytes, aes.CreateDecryptor());

            File.WriteAllText("C:\\Users\\Benjamin\\source\\repos\\AEuPLF12\\Decrpyt\\decrypted.pdf", decrypted);
        }

        public static string AesDecrypt(Byte[] inputBytes, ICryptoTransform decrypter)
        {
            Byte[] outputBytes = inputBytes;

            string plaintext = string.Empty;

            using (MemoryStream memoryStream = new MemoryStream(outputBytes))
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decrypter, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(cryptoStream))
                    {
                        plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }

            return plaintext;
        }
    }
}
