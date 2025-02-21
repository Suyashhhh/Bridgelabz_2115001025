using System;

class DivisionDemo
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("enter the numerator:");
            int numerator = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the denominator:");
            int denominator = int.Parse(Console.ReadLine());

            int result = numerator / denominator;
            Console.WriteLine("result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("error: cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid input: please enter integers only");
        }
        finally
        {
            Console.WriteLine("operation completed");
        }
    }
}
