
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if (year < 1582)
        {
            Console.WriteLine("Year must be greater than or equal to 1582.");
        }
        else
        {
            if (year % 400 == 0)
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }

            if ((year >= 1582) && ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))))
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }
    }
}

