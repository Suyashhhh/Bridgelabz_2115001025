using System;
using System.Text;

class Program
{
    static string RemoveDuplicates(string input)
    {
        StringBuilder sb = new StringBuilder();
        bool[] seen = new bool[256];
        foreach (char c in input)
        {
            if (!seen[c])
            {
                sb.Append(c);
                seen[c] = true;
            }
        }
        return sb.ToString();
    }

    static void Main()
    {
        string input = "banana";
        string result = RemoveDuplicates(input);
        Console.WriteLine("string without duplicates: " + result);
    }
}
