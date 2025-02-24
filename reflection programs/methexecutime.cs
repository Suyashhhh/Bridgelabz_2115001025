using System;
using System.Diagnostics;
using System.Reflection;

public class TaskRunner
{
    public void QuickTask()
    {
        Console.WriteLine("running quick task");
    }

    public void SlowTask()
    {
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("running slow task");
    }
}

public class ExecutionTimer
{
    public static void MeasureExecutionTime(object obj)
    {
        Type type = obj.GetType();
        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

        foreach (var method in methods)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            method.Invoke(obj, null);

            stopwatch.Stop();
            Console.WriteLine($"{method.Name} executed in {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TaskRunner runner = new TaskRunner();
        ExecutionTimer.MeasureExecutionTime(runner);
    }
}
