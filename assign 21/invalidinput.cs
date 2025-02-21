using System;

class InterestCalculator
{
    public static double CalculateInterest(double amount, double rate, int years)
    {
        if (amount < 0 || rate < 0)
        {
            throw new ArgumentException("amount and rate must be positive");
        }
        return amount * rate * years / 100;
    }

    public static void Main()
    {
        try
        {
            Console.WriteLine("enter amount:");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine("enter rate:");
            double rate = double.Parse(Console.ReadLine());

            Console.WriteLine("enter years:");
            int years = int.Parse(Console.ReadLine());

            double interest = CalculateInterest(amount, rate, years);
            Console.WriteLine("calculated interest: " + Math.Round(interest, 2));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("invalid input: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid input: please enter numeric values");
        }
    }
}
