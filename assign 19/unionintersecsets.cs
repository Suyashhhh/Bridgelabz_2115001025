using System;
using System.Collections.Generic;

class Program
{
    static HashSet<int> GetUnion(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> union = new HashSet<int>(set1);
        union.UnionWith(set2);
        return union;
    }

    static HashSet<int> GetIntersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> intersection = new HashSet<int>(set1);
        intersection.IntersectWith(set2);
        return intersection;
    }

    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        Console.WriteLine("Union: " + string.Join(", ", GetUnion(set1, set2)));
        Console.WriteLine("Intersection: " + string.Join(", ", GetIntersection(set1, set2)));
    }
}
