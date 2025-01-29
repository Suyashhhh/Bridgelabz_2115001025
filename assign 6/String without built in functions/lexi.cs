using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();
        int minLength = Math.Min(str1.Length, str2.Length);
        int result = 0;
        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] < str2[i])
            {
                result = -1;
                break;
            }
            else if (str1[i] > str2[i])
            {
                result = 1;
                break;
            }
        }
        if (result == 0)
        {
            if (str1.Length < str2.Length) result = -1;
            else if (str1.Length > str2.Length) result = 1;
        }
        if (result == -1) Console.WriteLine($"\"{str1}\" comes before \"{str2}\" in lexicographical order");
        else if (result == 1) Console.WriteLine($"\"{str1}\" comes after \"{str2}\" in lexicographical order");
    }
}

