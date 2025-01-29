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
            if (char.IsUpper(c))
            {
                result += char.ToLower(c);
            }
            else if (char.IsLower(c))
            {
                result += char.ToUpper(c);
            }
            else
            {
                result += c;
            }
        }
        Console.WriteLine("Toggled string: " + result);
    }
}



