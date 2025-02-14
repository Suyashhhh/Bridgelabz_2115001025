using System;

class Program
{
    static void CountingSort(int[] ages)
    {
        int minAge = 10, maxAge = 18;
        int range = maxAge - minAge + 1;
        int[] count = new int[range];
        int[] sortedAges = new int[ages.Length];

        for (int i = 0; i < ages.Length; i++) count[ages[i] - minAge]++;
        for (int i = 1; i < range; i++) count[i] += count[i - 1];
        for (int i = ages.Length - 1; i >= 0; i--) sortedAges[--count[ages[i] - minAge]] = ages[i];
        for (int i = 0; i < ages.Length; i++) ages[i] = sortedAges[i];
    }

    static void Main()
    {
        Console.Write("enter number of students: ");
        int n = int.Parse(Console.ReadLine());
        int[] ages = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"enter age {i + 1}: ");
            ages[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("before sorting:");
        foreach (int age in ages) Console.Write(age + " ");
        Console.WriteLine();

        CountingSort(ages);

        Console.WriteLine("after sorting:");
        foreach (int age in ages) Console.Write(age + " ");
        Console.WriteLine();
    }
}
