using System;
using System.Reflection;

public class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        Type type = typeof(Calculator);

        MethodInfo method = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

        if (method != null)
        {
            object result = method.Invoke(calculator, new object[] { 4, 5 });
            Console.WriteLine($"result of multiplication: {result}");
        }
        else
        {
            Console.WriteLine("method not found.");
        }
    }
}
