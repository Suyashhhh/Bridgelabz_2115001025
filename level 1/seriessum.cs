using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        if (n > 0)
        {
            int formulaSum = n * (n + 1) / 2;
            int loopSum = 0, i = 1;
            while (i <= n)
            {
                loopSum += i;
                i++;
            }
            if (formulaSum == loopSum)
                Console.WriteLine($"The sum of {n} natural numbers is {formulaSum} (using both formula and while loop). The results are correct!");
            else
                Console.WriteLine($"Mismatch in calculation");
        }
        else
        {
            Console.WriteLine("The entered number is not a natural number.");
        }
    }
}

