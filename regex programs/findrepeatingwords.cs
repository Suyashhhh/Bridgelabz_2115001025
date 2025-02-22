using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class RepeatingWordsFinder
{
    public List<string> FindRepeatingWords(string text)
    {
        string pattern = @"\b(\w+)\s+\1\b";
        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
        List<string> repeatingWords = new List<string>();

        foreach (Match match in matches)
        {
            repeatingWords.Add(match.Groups[1].Value);
        }

        return repeatingWords;
    }
}

public class Program
{
    public static void Main()
    {
        RepeatingWordsFinder finder = new RepeatingWordsFinder();
        string input = "This is is a repeated repeated word test.";

        List<string> repeatingWords = finder.FindRepeatingWords(input);

        Console.WriteLine("Repeating Words:");
        foreach (string word in repeatingWords)
        {
            Console.WriteLine(word);
        }
    }
}
