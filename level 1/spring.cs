using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the day (1-31): ");
        int day = int.Parse(Console.ReadLine());

        if ((month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day <= 20))
        {
            Console.WriteLine("It's a Spring Season.");
        }
        else
        {
            Console.WriteLine("Not a Spring Season.");
        }
    }
}

