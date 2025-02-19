using System;
using System.Collections.Generic;

class Program
{
    static HashSet<int> GetSymmetricDifference(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> symmetricDiff = new HashSet<int>(set1);
        symmetricDiff.SymmetricExceptWith(set2);
        return symmetricDiff;
    }

    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        Console.WriteLine(string.Join(", ", GetSymmetricDifference(set1, set2)));
    }
}
