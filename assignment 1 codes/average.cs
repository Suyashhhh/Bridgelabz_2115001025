using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double num3 = double.Parse(Console.ReadLine());
        double average = (num1 + num2 + num3) / 3;
        Console.WriteLine("Average: {0}", average);
    }
}
