using System;
using System.Diagnostics;

[AttributeUsage(AttributeTargets.Method)]
public class LogExecutionTimeAttribute : Attribute
{
}

class PerformanceTester
{
    public void FastMethod()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        for (int i = 0; i < 1000; i++)
        {
            int result = i * i;
        }
        stopwatch.Stop();
        Console.WriteLine($"fast method completed in {stopwatch.ElapsedMilliseconds} ms");
    }

    public void SlowMethod()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        for (int i = 0; i < 1000000; i++)
        {
            int result = i * i;
        }
        stopwatch.Stop();
        Console.WriteLine($"slow method completed in {stopwatch.ElapsedMilliseconds} ms");
    }

    public void NoLogMethod()
    {
        Console.WriteLine("this method doesn't track execution time");
    }
}

class Program
{
    static void Main(string[] args)
    {
        PerformanceTester tester = new PerformanceTester();
        tester.FastMethod();
        tester.SlowMethod();
        tester.NoLogMethod();
    }
}
