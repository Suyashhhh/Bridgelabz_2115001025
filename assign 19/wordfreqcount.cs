using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static Dictionary<string, int> WordFrequencyCounter(string filePath)
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        string text = File.ReadAllText(filePath).ToLower();
        foreach (string word in Regex.Split(text, @"\W+").Where(w => w.Length > 0))
            wordCount[word] = wordCount.ContainsKey(word) ? wordCount[word] + 1 : 1;
        return wordCount;
    }

    static void Main()
    {
        string filePath = "input.txt";
        foreach (var kvp in WordFrequencyCounter(filePath))
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}
