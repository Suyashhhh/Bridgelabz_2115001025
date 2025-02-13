using System;
using System.Collections.Generic;

class Program
{
    static int LongestConsecutiveSequence(int[] arr)
    {
        HashSet<int> set = new HashSet<int>(arr);
        int longest = 0;

        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int currentNum = num, count = 1;
                while (set.Contains(currentNum + 1))
                {
                    currentNum++;
                    count++;
                }
                longest = Math.Max(longest, count);
            }
        }
        return longest;
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

        Console.WriteLine("longest consecutive sequence length: " + LongestConsecutiveSequence(arr));
    }
}
