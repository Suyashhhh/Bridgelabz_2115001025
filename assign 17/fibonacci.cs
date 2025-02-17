using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int[] testCases = { 10, 30, 50 };

        foreach (int n in testCases)
        {
            Console.WriteLine($"\nfibonacci({n}):");

            Stopwatch sw = new Stopwatch();

            if (n <= 30)
            {
                sw.Start();
                FibonacciRecursive(n);
                sw.Stop();
                Console.WriteLine($"recursive: {sw.Elapsed.TotalSeconds} s");
            }
            else
            {
                Console.WriteLine("recursive: unfeasible (O(2^N) exponential growth)");
            }

            sw.Restart();
            FibonacciIterative(n);
            sw.Stop();
            Console.WriteLine($"iterative: {sw.Elapsed.TotalSeconds} s");
        }
    }

    static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    static int FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            int sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}
