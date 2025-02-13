using System;
using System.Collections.Generic;

class Program
{
    static int[] SlidingWindowMaximum(int[] arr, int k)
    {
        int n = arr.Length;
        int[] result = new int[n - k + 1];
        LinkedList<int> deque = new LinkedList<int>();

        for (int i = 0; i < n; i++)
        {
            if (deque.Count > 0 && deque.First.Value < i - k + 1)
                deque.RemoveFirst();

            while (deque.Count > 0 && arr[deque.Last.Value] <= arr[i])
                deque.RemoveLast();

            deque.AddLast(i);

            if (i >= k - 1) result[i - k + 1] = arr[deque.First.Value];
        }
        return result;
    }

    static void Main()
    {
        Console.Write("enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"enter element {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("enter window size: ");
        int k = int.Parse(Console.ReadLine());

        int[] maxValues = SlidingWindowMaximum(arr, k);

        Console.WriteLine("maximum in each window:");
        foreach (int max in maxValues) Console.Write(max + " ");
        Console.WriteLine();
    }
}
