using System;
using System.Text;

class Program
{
    static string ReverseString(string input)
    {
        StringBuilder sb = new StringBuilder(input);
        int left = 0, right = sb.Length - 1;
        while (left < right)
        {
            char temp = sb[left];
            sb[left] = sb[right];
            sb[right] = temp;
            left++;
            right--;
        }
        return sb.ToString();
    }

    static void Main()
    {
        string input = "hello";
        string reversed = ReverseString(input);
        Console.WriteLine("reversed string: " + reversed);
    }
}
