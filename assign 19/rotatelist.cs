using System;
using System.Collections.Generic;

class Program
{
    static List<int> RotateList(List<int> items, int k)
    {
        int n = items.Count;
        k %= n;
        List<int> rotated = new List<int>(items.GetRange(k, n - k));
        rotated.AddRange(items.GetRange(0, k));
        return rotated;
    }

    static void Main()
    {
        List<int> items = new List<int> { 10, 20, 30, 40, 50 };
        int k = 2;
        List<int> result = RotateList(items, k);
        Console.WriteLine(string.Join(", ", result));
    }
}
