
using System;

class Program
{
    static void Main()
    {
        Console.Write("enter the first date (yyyy-mm-dd): ");
        DateTime date1 = DateTime.Parse(Console.ReadLine());

        Console.Write("enter the second date (yyyy-mm-dd): ");
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        int comparisonResult = date1.CompareTo(date2);

        if (comparisonResult < 0)
        {
            Console.WriteLine("the first date is before the second date.");
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine("the first date is after the second date.");
        }
        else
        {
            Console.WriteLine("the first date is the same as the second date.");
        }
    }
}

