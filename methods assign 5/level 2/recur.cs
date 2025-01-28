using System;

class NaturalNumbersSum
{
    static void Main()
    {
        Console.Write("enter a natural number: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("please enter a valid natural number");
            return;
        }
        int recursiveSum = RecursiveSum(n);
        int formulaSum = FormulaSum(n);
        Console.WriteLine("sum using recursion: " + recursiveSum);
        Console.WriteLine("sum using formula: " + formulaSum);
        Console.WriteLine("results match: " + (recursiveSum == formulaSum));
    }

    static int RecursiveSum(int n)
    {
        if (n == 1) return 1;
        return n + RecursiveSum(n - 1);
    }

    static int FormulaSum(int n)
    {
        return n * (n + 1) / 2;
    }
}

