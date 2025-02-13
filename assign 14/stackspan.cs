using System;
using System.Collections.Generic;

class Program
{
    static int[] CalculateStockSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
                stack.Pop();

            span[i] = stack.Count == 0 ? i + 1 : i - stack.Peek();
            stack.Push(i);
        }
        return span;
    }

    static void Main()
    {
        Console.Write("enter number of days: ");
        int n = int.Parse(Console.ReadLine());
        int[] prices = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"enter stock price for day {i + 1}: ");
            prices[i] = int.Parse(Console.ReadLine());
        }

        int[] span = CalculateStockSpan(prices);

        Console.WriteLine("day price span");
        for (int i = 0; i < n; i++)
            Console.WriteLine(i + 1 + " " + prices[i] + " " + span[i]);
    }
}
