
using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        Console.WriteLine("Enter 5 numbers:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                if (numbers[i] % 2 == 0)
                    Console.WriteLine($"Number {numbers[i]} is positive and even.");
                else
                    Console.WriteLine($"Number {numbers[i]} is positive and odd.");
            }
            else if (numbers[i] < 0)
            {
                Console.WriteLine($"Number {numbers[i]} is negative.");
            }
            else
            {
                Console.WriteLine($"Number {numbers[i]} is zero.");
            }
        }

        if (numbers[0] == numbers[^1])
            Console.WriteLine("The first and last elements are equal.");
        else if (numbers[0] > numbers[^1])
            Console.WriteLine("The first element is greater than the last element.");
        else
            Console.WriteLine("The first element is less than the last element.");
    }
}

