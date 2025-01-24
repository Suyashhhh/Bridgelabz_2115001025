
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        int temp = number, count = 0;
        while (temp != 0)
        {
            count++;
            temp /= 10;
        }

        int[] digits = new int[count];
        temp = number;
        for (int i = 0; i < count; i++)
        {
            digits[i] = temp % 10;
            temp /= 10;
        }

        Console.Write("Reversed number: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(digits[i]);
        }
        Console.WriteLine();
    }
}

