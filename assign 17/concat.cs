using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] words = { "one", "two", "ka", "four", ":p" };
        StringBuilder sb = new StringBuilder();

        foreach (string word in words)
            sb.Append(word).Append(" ");

        Console.WriteLine(sb.ToString().Trim());
    }
}
