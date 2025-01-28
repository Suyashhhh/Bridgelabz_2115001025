using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the first number (dividend): ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number (divisor): ");
        int divisor = int.Parse(Console.ReadLine());
        int[] result = FindRemainderAndQuotient(number, divisor);
        Console.WriteLine($"Quotient: {result[0]}, Remainder: {result[1]}");
    }
    static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        return new int[] { number / divisor, number % divisor };
    }
}

