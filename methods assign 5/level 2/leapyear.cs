using System;

class LeapYearChecker
{
    static void Main()
    {
        Console.Write("enter a year: ");
        int year = int.Parse(Console.ReadLine());
        if (year < 1582)
        {
            Console.WriteLine("the year must be 1582 or later");
            return;
        }
        Console.WriteLine(IsLeapYear(year) ? "the year is a leap year" : "the year is not a leap year");
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}

