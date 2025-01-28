
using System;

class FactorsProgram
{
    static void Main()
    {
        Console.Write("enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int[] factors = FindFactors(number);
        Console.Write("factors: ");
        for (int i = 0; i < factors.Length; i++) Console.Write(factors[i] + (i < factors.Length - 1 ? ", " : ""));
        Console.WriteLine();
        int sum = CalculateSum(factors);
        Console.WriteLine("sum of factors: " + sum);
        int sumOfSquares = CalculateSumOfSquares(factors);
        Console.WriteLine("sum of squares of factors: " + sumOfSquares);
        long product = CalculateProduct(factors);
        Console.WriteLine("product of factors: " + product);
    }
    static int[] FindFactors(int num)
    {
        int count = 0;
        for (int i = 1; i <= num; i++) if (num % i == 0) count++;
        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= num; i++) if (num % i == 0) factors[index++] = i;
        return factors;
    }
    static int CalculateSum(int[] factors)
    {
        int sum = 0;
        for (int i = 0; i < factors.Length; i++) sum += factors[i];
        return sum;
    }
    static int CalculateSumOfSquares(int[] factors)
    {
        int sum = 0;
        for (int i = 0; i < factors.Length; i++) sum += (int)Math.Pow(factors[i], 2);
        return sum;
    }
    static long CalculateProduct(int[] factors)
    {
        long product = 1;
        for (int i = 0; i < factors.Length; i++) product *= factors[i];
        return product;
    }
}
