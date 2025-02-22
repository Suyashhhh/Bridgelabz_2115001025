using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class CurrencyExtractor
{
    public List<string> ExtractCurrencyValues(string text)
    {
        string pattern = @"\$ ?\d+(\.\d{2})?";
        MatchCollection matches = Regex.Matches(text, pattern);
        List<string> currencyValues = new List<string>();

        foreach (Match match in matches)
        {
            string value = match.Value.Replace("$", "").Trim();
            currencyValues.Add(value);
        }

        return currencyValues;
    }
}

public class Program
{
    public static void Main()
    {
        CurrencyExtractor extractor = new CurrencyExtractor();
        string input = "The price is $45.99, and the discount is $ 10.50.";

        List<string> extractedValues = extractor.ExtractCurrencyValues(input);

        Console.WriteLine("Extracted Currency Values:");
        foreach (string value in extractedValues)
        {
            Console.WriteLine(value);
        }
    }
}

