using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter the power: ");
        int power = int.Parse(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }

        Console.WriteLine($"{number} raised to the power of {power} is {result}.");
    }
}

