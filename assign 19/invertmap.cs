using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<V, List<K>> InvertMap<K, V>(Dictionary<K, V> map)
    {
        Dictionary<V, List<K>> inverted = new Dictionary<V, List<K>>();

        foreach (var kvp in map)
        {
            if (!inverted.ContainsKey(kvp.Value))
                inverted[kvp.Value] = new List<K>();
            inverted[kvp.Value].Add(kvp.Key);
        }
        return inverted;
    }

    static void Main()
    {
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            { "A", 1 }, { "B", 2 }, { "C", 1 }
        };

        var result = InvertMap(input);
        foreach (var kvp in result)
            Console.WriteLine($"{kvp.Key}: [{string.Join(", ", kvp.Value)}]");
    }
}
