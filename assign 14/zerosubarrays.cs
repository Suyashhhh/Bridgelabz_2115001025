using System;
using System.Collections.Generic;

class Program
{
    static void FindZeroSumSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        int sum = 0;
        bool found = false;

        map[0] = new List<int> { -1 };

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (map.ContainsKey(sum))
            {
                foreach (int start in map[sum])
                {
                    Console.WriteLine("subarray from index " + (start + 1) + " to " + i);
                    found = true;
                }
            }

            if (!map.ContainsKey(sum)) map[sum] = new List<int>();
            map[sum].Add(i);
        }

        if (!found) Console.WriteLine("no zero-sum subarrays found");
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

        FindZeroSumSubarrays(arr);
    }
}
