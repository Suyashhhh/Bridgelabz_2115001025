
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        if (number == 0)
        {
            count = 1;
        }
        else
        {
            while (number != 0)
            {
                number /= 10;
                count++;
            }
        }
        Console.WriteLine($"The number of digits is: {count}");
    }
}

