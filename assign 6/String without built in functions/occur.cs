using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.Write("Enter character to remove: ");
        char removeChar = Console.ReadKey().KeyChar;
        string result = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != removeChar)
            {
                result += input[i];
            }
        }
        Console.WriteLine("\nModified String: " + result);
    }
}

