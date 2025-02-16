using System;

class Program
{
    static void Main()
    {
        string[] sentences = {
            "hello world",
            "this is a test",
            "c# is fun",
            "learning linear search"
        };
        
        string word = "is";
        
        foreach (string sentence in sentences)
            if (sentence.Contains(word))
            {
                Console.WriteLine(sentence);
                return;
            }
    }
}
