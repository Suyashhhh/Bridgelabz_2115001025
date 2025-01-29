using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string result = "";
        foreach (char c in input)
        {
            if (!result.Contains(c))
            {
                result += c;
            }
        }
        Console.WriteLine("Modified string: " + result);
    }
}

