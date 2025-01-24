
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        int[] digits = new int[10];
        int[] frequency = new int[10];

        while (number > 0)
        {
            int digit = number % 10;
            digits[digits.Length - 1] = digit;
            frequency[digit]++;
            number /= 10;
        }

        Console.WriteLine("Digit | Frequency");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine($"{i} | {frequency[i]}");
            }
        }
    }
}

