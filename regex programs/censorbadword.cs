using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class BadWordCensor
{
    public string CensorBadWords(string text, List<string> badWords)
    {
        string pattern = string.Join("|", badWords);
        string censoredText = Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);
        return censoredText;
    }
}

public class Program
{
    public static void Main()
    {
        BadWordCensor censor = new BadWordCensor();

        List<string> badWords = new List<string> { "damn", "shit",”stupid” };
        string input = "This is a damn bad example with some stupid words.";
        string result = censor.CensorBadWords(input, badWords);

        Console.WriteLine("Original Text:");
        Console.WriteLine(input);
        Console.WriteLine("Censored Text:");
        Console.WriteLine(result);
    }
}
