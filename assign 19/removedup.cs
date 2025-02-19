using System;
using System.Collections.Generic;

class Program
{
    static List<int> RemoveDuplicates(List<int> items)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();
        foreach (int item in items)
            if (seen.Add(item))
                result.Add(item);
        return result;
    }

    static void Main()
    {
        List<int> items = new List<int> { 3, 1, 2, 2, 3, 4 };
        List<int> result = RemoveDuplicates(items);
        Console.WriteLine(string.Join(", ", result));
    }
}
