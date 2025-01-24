
using System;
class Program
{
    static void Main()
    {
        double[] numbers = new double[10]; double total = 0.0; int index = 0;
        Console.WriteLine("Enter up to 10 numbers (enter 0 or a negative number to stop):");
        while (true)
        {
            Console.Write($"Number {index + 1}: ");
            double input = double.Parse(Console.ReadLine());
            if (input <= 0 || index == 10) break;
            numbers[index++] = input;
        }
        Console.WriteLine("\nYou entered the following numbers:");
        for (int i = 0; i < index; i++) { Console.WriteLine(numbers[i]); total += numbers[i]; }
        Console.WriteLine($"\nThe total of the numbers is: {total}");
    }
}

