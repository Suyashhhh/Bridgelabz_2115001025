using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class CSVEncryptorDecryptor
{
    private readonly string key = "1234567890123456"; // 16-char key for AES

    public void EncryptCsv(string inputPath, string outputPath)
    {
        try
        {
            if (!File.Exists(inputPath))
            {
                Console.WriteLine("file not found.");
                return;
            }

            var lines = File.ReadAllLines(inputPath);
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                writer.WriteLine(lines[0]); // header
                for (int i = 1; i < lines.Length; i++)
                {
                    var fields = lines[i].Split(',');
                    fields[3] = Encrypt(fields[3]); // Encrypt Salary
                    fields[4] = Encrypt(fields[4]); // Encrypt Email
                    writer.WriteLine(string.Join(",", fields));
                }
            }

            Console.WriteLine("csv data encrypted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }

    public void DecryptCsv(string inputPath, string outputPath)
    {
        try
        {
            if (!File.Exists(inputPath))
            {
                Console.WriteLine("file not found.");
                return;
            }

            var lines = File.ReadAllLines(inputPath);
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                writer.WriteLine(lines[0]); // header
                for (int i = 1; i < lines.Length; i++)
                {
                    var fields = lines[i].Split(',');
                    fields[3] = Decrypt(fields[3]); // Decrypt Salary
                    fields[4] = Decrypt(fields[4]); // Decrypt Email
                    writer.WriteLine(string.Join(",", fields));
                }
            }

            Console.WriteLine("csv data decrypted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }

    private string Encrypt(string plainText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.GenerateIV();
            using (var encryptor = aes.CreateEncryptor())
            {
                var plainBytes = Encoding.UTF8.GetBytes(plainText);
                var encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                return Convert.ToBase64String(aes.IV) + ":" + Convert.ToBase64String(encryptedBytes);
            }
        }
    }

    private string Decrypt(string encryptedText)
    {
        var parts = encryptedText.Split(':');
        var iv = Convert.FromBase64String(parts[0]);
        var cipherText = Convert.FromBase64String(parts[1]);

        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = iv;
            using (var decryptor = aes.CreateDecryptor())
            {
                var decryptedBytes = decryptor.TransformFinalBlock(cipherText, 0, cipherText.Length);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
    }

    static void Main()
    {
        var encryptorDecryptor = new CSVEncryptorDecryptor();
        encryptorDecryptor.EncryptCsv("sensitive_data.csv", "encrypted_data.csv");
        encryptorDecryptor.DecryptCsv("encrypted_data.csv", "decrypted_data.csv");
    }
}
