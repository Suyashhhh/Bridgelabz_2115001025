using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double sum = num1 + num2;

        Console.WriteLine("The sum of {0} and {1} is {2}.", num1, num2, sum);
    }
}