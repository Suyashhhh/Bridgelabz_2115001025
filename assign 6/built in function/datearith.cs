using System;
class Program
{
    static void Main()
    {
        Console.Write("enter a date (yyyy-mm-dd): ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());

        DateTime result = inputDate
            .AddDays(7)     // add 7 days
            .AddMonths(1)   // add 1 month
            .AddYears(2)    // add 2 years
            .AddDays(-21);  // subtract 3 weeks (21 days)

        Console.WriteLine("resulting date: " + result.ToString("yyyy-MM-dd"));
    }
}

