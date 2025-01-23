
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"{i} is an even number.");
                else
                    Console.WriteLine($"{i} is an odd number.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a natural number greater than 0.");
        }
    }
}

