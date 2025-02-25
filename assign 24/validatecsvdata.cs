using System;
using System.IO;
using System.Text.RegularExpressions;

class CSVValidator
{
    public void ValidateData(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("file not found.");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            Regex emailPattern = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            Regex phonePattern = new Regex(@"^\d{10}$");

            Console.WriteLine("invalid records:");
            for (int i = 1; i < lines.Length; i++)
            {
                var fields = lines[i].Split(',');
                string email = fields[2];
                string phone = fields[3];

                bool validEmail = emailPattern.IsMatch(email);
                bool validPhone = phonePattern.IsMatch(phone);

                if (!validEmail || !validPhone)
                {
                    Console.WriteLine($"Row {i + 1}: {lines[i]} - Invalid {(validEmail ? "" : "Email")} {(validPhone ? "" : "Phone")}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }

    static void Main()
    {
        var validator = new CSVValidator();
        validator.ValidateData("contacts.csv");
    }
}
