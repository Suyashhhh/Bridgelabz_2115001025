using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, int> CountFrequency(List<string> items)
    {
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        foreach (string item in items)
            frequency[item] = frequency.ContainsKey(item) ? frequency[item] + 1 : 1;
        return frequency;
    }

    static void Main()
    {
        List<string> items = new List<string> { "apple", "banana", "apple", "orange" };
        Dictionary<string, int> result = CountFrequency(items);
        foreach (var pair in result)
            Console.WriteLine(pair.Key + ": " + pair.Value);
    }
}
