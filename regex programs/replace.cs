using System;
using System.Text.RegularExpressions;

public class SpaceReplacer
{
    public string ReplaceMultipleSpaces(string text)
    {
        string pattern = @"\s+";
        string replacedText = Regex.Replace(text, pattern, " ");
        return replacedText.Trim();
    }
}

public class Program
{
    public static void Main()
    {
        SpaceReplacer replacer = new SpaceReplacer();

        string input = "This    is   an    example   with     multiple      spaces.";
        string result = replacer.ReplaceMultipleSpaces(input);

        Console.WriteLine("Original Text:");
        Console.WriteLine(input);
        Console.WriteLine("Modified Text:");
        Console.WriteLine(result);
    }
}
