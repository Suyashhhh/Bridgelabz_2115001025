using System;
using System.Collections.Generic;

[AttributeUsage(AttributeTargets.Method)]
public class CacheResultAttribute : Attribute
{
}

public class ExpensiveComputation
{
    private Dictionary<int, long> cache = new Dictionary<int, long>();

    [CacheResult]
    public long ComputeFactorial(int n)
    {
        if (cache.ContainsKey(n))
        {
            Console.WriteLine($"retrieving cached result for input {n}");
            return cache[n];
        }

        Console.WriteLine($"computing result for input {n}");
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        cache[n] = result;
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ExpensiveComputation computation = new ExpensiveComputation();

        Console.WriteLine($"factorial of 5: {computation.ComputeFactorial(5)}");
        Console.WriteLine($"factorial of 6: {computation.ComputeFactorial(6)}");
        Console.WriteLine($"factorial of 5 (cached): {computation.ComputeFactorial(5)}");
        Console.WriteLine($"factorial of 6 (cached): {computation.ComputeFactorial(6)}");
    }
}
