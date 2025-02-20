using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class WordCounter
{
    static void Main()
    {
        string filePath = "textfile.txt";

        try
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = Regex.Split(line.ToLower(), @"\W+");
                    foreach (string word in words)
                    {
                        if (!string.IsNullOrEmpty(word))
                        {
                            if (!wordCount.ContainsKey(word))
                                wordCount[word] = 0;
                            wordCount[word]++;
                        }
                    }
                }
            }

            Console.WriteLine("total words: " + wordCount.Values.Sum());

            var topWords = wordCount.OrderByDescending(kvp => kvp.Value).Take(5);
            Console.WriteLine("top 5 words:");
            foreach (var pair in topWords)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("file not found.");
        }
        catch (IOException e)
        {
            Console.WriteLine("io error: " + e.Message);
        }
    }
}
