using System;

class DivisionHandler
{
    public void PerformDivision()
    {
        try
        {
            Console.WriteLine("enter the numerator:");
            double numerator = double.Parse(Console.ReadLine());

            Console.WriteLine("enter the denominator:");
            double denominator = double.Parse(Console.ReadLine());

            double result = numerator / denominator;
            Console.WriteLine("result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid input, please enter numeric values");
        }
    }
}

class Program
{
    static void Main()
    {
        DivisionHandler handler = new DivisionHandler();
        handler.PerformDivision();
    }
}
