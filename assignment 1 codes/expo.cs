using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the base: ");
        double baseNum = double.Parse(Console.ReadLine());
        Console.Write("Enter the exponent: ");
        double exponent = double.Parse(Console.ReadLine());
        double result = Math.Pow(baseNum, exponent);
        Console.WriteLine("Result: {0}", result);
    }
}
