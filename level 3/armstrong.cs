
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine()); 
        int temp = num;
        int unit;
        int sum = 0;
        int digits = num.ToString().Length; 

        while (temp != 0)
        {
            unit = temp % 10;
            sum += (int)Math.Pow(unit, digits); //i used (int)(Math.Pow(unit,digits)) will return 124 instead of 125 as it will directly type cast 124.999 into 124  
            temp /= 10; 
        }

        if (sum == num)
        {
            Console.WriteLine("The entered number is an Armstrong number.");
        }
        else
        {
            Console.WriteLine("Not an Armstrong number.");
        }
    }
}

