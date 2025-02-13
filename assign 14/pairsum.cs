using System;
using System.Collections.Generic;

class Program
{
    static bool HasPairWithSum(int[] arr, int target)
    {
        HashSet<int> seen = new HashSet<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];

            if (seen.Contains(complement))
            {
                Console.WriteLine("pair found: " + complement + " " + arr[i]);
                return true;
            }

            seen.Add(arr[i]);
        }

        Console.WriteLine("no pair found");
        return false;
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

        Console.Write("enter target sum: ");
        int target = int.Parse(Console.ReadLine());

        HasPairWithSum(arr, target);
    }
}
