using System;
using System.Collections.Generic;

class Program
{
    static void SortStack(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            int top = stack.Pop();
            SortStack(stack);
            InsertSorted(stack, top);
        }
    }

    static void InsertSorted(Stack<int> stack, int value)
    {
        if (stack.Count == 0 || stack.Peek() <= value)
        {
            stack.Push(value);
        }
        else
        {
            int top = stack.Pop();
            InsertSorted(stack, value);
            stack.Push(top);
        }
    }

    static void Main()
    {
        Stack<int> stack = new Stack<int>();

        Console.Write("enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"enter element {i + 1}: ");
            stack.Push(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("before sorting:");
        foreach (int num in stack) Console.Write(num + " ");
        Console.WriteLine();

        SortStack(stack);

        Console.WriteLine("after sorting:");
        foreach (int num in stack) Console.Write(num + " ");
        Console.WriteLine();
    }
}
