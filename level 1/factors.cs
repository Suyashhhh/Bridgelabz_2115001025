
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int maxFactor = 10, index = 0;
        int[] factors = new int[maxFactor];
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                if (index == maxFactor)
                {
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    factors.CopyTo(temp, 0);
                    factors = temp;
                }
                factors[index++] = i;
            }
        }
        Console.Write("Factors of " + number + ": ");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
    }
}

