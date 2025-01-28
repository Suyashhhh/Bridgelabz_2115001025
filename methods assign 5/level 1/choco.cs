using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());
        int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);
        Console.WriteLine($"Each child will get {result[0]} chocolates, and {result[1]} chocolates will remain.");
    }
    static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        return new int[] { number / divisor, number % divisor };
    }
}

