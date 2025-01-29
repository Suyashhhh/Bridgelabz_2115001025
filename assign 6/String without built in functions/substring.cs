using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.Write("Enter a substring: ");
        string substring = Console.ReadLine();
        int count = 0;
        int index = 0;
        while ((index = input.IndexOf(substring, index)) != -1)
        {
            count++;
            index += substring.Length;
        }
        Console.WriteLine("Substring occurrences: " + count);
    }
}

