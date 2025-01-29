using System;
class Program
{
    static string GetInput()
    {
        Console.Write("Enter a string: ");
        return Console.ReadLine();
    }

    static bool IsPalindrome(string str)
    {
        int start = 0, end = str.Length - 1;
        while (start < end)
        {
            if (str[start] != str[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }

    static void DisplayResult(bool isPalindrome)
    {
        if (isPalindrome)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }

    static void Main()
    {
        string input = GetInput();
        bool result = IsPalindrome(input);
        DisplayResult(result);
    }
}

