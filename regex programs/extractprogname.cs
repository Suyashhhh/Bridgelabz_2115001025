using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class LanguageExtractor
{
    public List<string> ExtractLanguages(string text)
    {
        string pattern = @"\b(Java|Python|JavaScript|Go)\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        List<string> languages = new List<string>();

        foreach (Match match in matches)
        {
            languages.Add(match.Value);
        }

        return languages;
    }
}

public class Program
{
    public static void Main()
    {
        LanguageExtractor extractor = new LanguageExtractor();
        string input = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";

        List<string> extractedLanguages = extractor.ExtractLanguages(input);

        Console.WriteLine("Extracted Programming Languages:");
        foreach (string language in extractedLanguages)
        {
            Console.WriteLine(language);
        }
    }
}
