using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the principal amount: ");
        double principal = double.Parse(Console.ReadLine());
        Console.Write("Enter the rate of interest: ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Enter the time period (in years): ");
        double time = double.Parse(Console.ReadLine());
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine("Simple Interest: {0}", simpleInterest);
    }
}
