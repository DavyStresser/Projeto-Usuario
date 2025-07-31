using System.Security.Cryptography;
using System.Text;

namespace GISA.Helper
{
    public class EncryptionService

    {// 32 bytes key (AES-256) and 16 bytes IV
        private static readonly byte[] key = Encoding.UTF8.GetBytes("12345678901234567890123456789012"); // 32 bytes
        private static readonly byte[] iv = Encoding.UTF8.GetBytes("1234567890123456"); // 16 bytes

        private const string Secret = "averylongtext!@$@#$#@$#*&(*&}{23432432432dsfsdf_cnes";

        public static string Decrypt(string input, int isEncrypted)
        {
            if (isEncrypted != 1)
                return input?.ToUpper(); // Se não estiver encriptado, retorna o texto em caixa alta

            try
            {
                byte[] key = DeriveKeyFromSecret(Secret);
                byte[] iv = new byte[16]; // IV de 16 bytes zerados
                byte[] cipherBytes = ConvertHexStringToByteArray(input);

                using (Aes aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;
                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.PKCS7;

                    using var decryptor = aes.CreateDecryptor();
                    using var ms = new MemoryStream(cipherBytes);
                    using var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
                    using var sr = new StreamReader(cs, Encoding.UTF8);
                    string decrypted = sr.ReadToEnd();
                    return decrypted.ToUpper(); // retorna o resultado descriptografado e em caixa alta
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao descriptografar: {ex.Message}");
                return null;
            }
        }

        private static byte[] DeriveKeyFromSecret(string secret)
        {
            using var sha256 = SHA256.Create();
            byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(secret));
            byte[] key16 = new byte[16];
            Array.Copy(hash, key16, 16);
            return key16;
        }

        private static byte[] ConvertHexStringToByteArray(string hex)
        {
            int length = hex.Length;
            byte[] bytes = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }


        public static string EncryptStringPec(string plainText)
        {
            byte[] key = DeriveKeyFromSecret(Secret);
            byte[] iv = new byte[16]; // IV de 16 bytes zerados

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }

                    byte[] encryptedBytes = msEncrypt.ToArray();
                    return BitConverter.ToString(encryptedBytes).Replace("-", "").ToLower(); // Retorna como hex string
                }
            }
        }

        public static string DecryptString(string cipherText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    
        public static string EncryptString(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
        }
    }
}
