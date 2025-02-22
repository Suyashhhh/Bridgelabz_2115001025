using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class EmailProcessor
{
    public List<string> ExtractEmails(string text)
    {
        string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
        MatchCollection matches = Regex.Matches(text, pattern);

        List<string> emails = new List<string>();
        foreach (Match match in matches)
        {
            emails.Add(match.Value);
        }
        return emails;
    }

    public bool IsValidEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        return Regex.IsMatch(email, pattern);
    }
}

public class Program
{
    public static void Main()
    {
        EmailProcessor processor = new EmailProcessor();

        string text = "Contact us at support@example.com and info@company.org. Invalid: test@.com";
        List<string> emails = processor.ExtractEmails(text);

        Console.WriteLine("Extracted Emails:");
        foreach (string email in emails)
        {
            Console.WriteLine(email);
        }

        Console.WriteLine("\nValidation Results:");
        foreach (string email in emails)
        {
            Console.WriteLine($"{email} → {(processor.IsValidEmail(email) ? "Valid" : "Invalid")}");
        }
    }
}
