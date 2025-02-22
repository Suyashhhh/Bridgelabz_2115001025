using System;
using System.Text.RegularExpressions;

public class SSNValidator
{
    public bool IsValidSSN(string text)
    {
        string pattern = @"\b\d{3}-\d{2}-\d{4}\b";
        return Regex.IsMatch(text, pattern);
    }

    public string ExtractSSN(string text)
    {
        string pattern = @"\b\d{3}-\d{2}-\d{4}\b";
        Match match = Regex.Match(text, pattern);
        return match.Success ? match.Value : "No valid SSN found";
    }
}

public class Program
{
    public static void Main()
    {
        SSNValidator validator = new SSNValidator();

        string validInput = "My SSN is 123-45-6789.";
        string invalidInput = "My SSN is 123456789.";

        Console.WriteLine("Validation Results:");

        string extractedSSN = validator.ExtractSSN(validInput);
        Console.WriteLine(extractedSSN != "No valid SSN found" ? $"{extractedSSN} is valid" : "No valid SSN found");

        bool isValid = validator.IsValidSSN(invalidInput);
        Console.WriteLine(isValid ? "123456789 is valid" : "123456789 is invalid");
    }
}
