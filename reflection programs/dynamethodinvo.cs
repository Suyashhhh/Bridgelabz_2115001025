using System;
using System.Reflection;

public class MathOperations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
}

class Program
{
    static void Main(string[] args)
    {
        MathOperations math = new MathOperations();

        Console.WriteLine("enter method name (Add, Subtract, Multiply):");
        string methodName = Console.ReadLine();

        Console.WriteLine("enter two numbers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        MethodInfo method = typeof(MathOperations).GetMethod(methodName);

        if (method != null)
        {
            object result = method.Invoke(math, new object[] { num1, num2 });
            Console.WriteLine($"result: {result}");
        }
        else
        {
            Console.WriteLine("method not found");
        }
    }
}
