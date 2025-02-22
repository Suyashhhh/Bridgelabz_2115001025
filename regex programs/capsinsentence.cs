
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class CapitalizedWordExtractor
{
    public List<string> ExtractCapitalizedWords(string text)
    {
        string pattern = @"\b[A-Z][a-z]*\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        List<string> capitalizedWords = new List<string>();
        foreach (Match match in matches)
        {
            capitalizedWords.Add(match.Value);
        }
        return capitalizedWords;
    }
}

public class Program
{
    public static void Main()
    {
        CapitalizedWordExtractor extractor = new CapitalizedWordExtractor();

        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
        List<string> capitalizedWords = extractor.ExtractCapitalizedWords(text);

        Console.WriteLine("Capitalized Words:");
        foreach (string word in capitalizedWords)
        {
            Console.WriteLine(word);
        }
    }
}

