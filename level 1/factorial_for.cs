
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());
        if (number >= 0)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
                factorial *= i;
            Console.WriteLine($"The factorial of {number} is {factorial}.");
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}

p
