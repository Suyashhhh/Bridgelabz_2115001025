using System;
using System.Collections.Generic;

class Program
{
    static List<string> GenerateBinaryNumbers(int n)
    {
        Queue<string> queue = new Queue<string>();
        List<string> result = new List<string>();
        queue.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            string current = queue.Dequeue();
            result.Add(current);
            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }
        return result;
    }

    static void Main()
    {
        int n = 5;
        Console.WriteLine(string.Join(", ", GenerateBinaryNumbers(n)));
    }
}
