using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "sample.txt";
        string word = "hello";
        int count = 0;

        using StreamReader sr = new StreamReader(path);
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            int index = 0;
            while ((index = line.IndexOf(word, index)) != -1)
            {
                count++;
                index += word.Length;
            }
        }

        Console.WriteLine("occurrences: " + count);
    }
}
