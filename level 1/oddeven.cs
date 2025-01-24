
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());
        if (number <= 0) 
        { 
            Console.WriteLine("Error: Enter a natural number greater than 0."); 
            return; 
        }
        int[] evens = new int[number / 2 + 1], odds = new int[number / 2 + 1];
        int evenIndex = 0, oddIndex = 0;
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evens[evenIndex++] = i;
            }
            else
            {
                odds[oddIndex++] = i;
            }
        }
        Console.Write("Even numbers: ");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evens[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Odd numbers: ");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(odds[i] + " ");
        }
    }
}

