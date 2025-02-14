
using System;

class Program
{
    static void InsertionSort(int[] ids)
    {
        int n = ids.Length;
        for (int i = 1; i < n; i++)
        {
            int key = ids[i];
            int j = i - 1;
            while (j >= 0 && ids[j] > key)
            {
                ids[j + 1] = ids[j];
                j--;
            }
            ids[j + 1] = key;
        }
    }

    static void Main()
    {
        Console.Write("enter number of employees: ");
        int n = int.Parse(Console.ReadLine());
        int[] ids = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"enter employee id {i + 1}: ");
            ids[i] = int.Parse(Console.ReadLine());
        }
        InsertionSort(ids);

        Console.WriteLine("after sorting:");
        foreach (int id in ids) Console.Write(id + " ");
        Console.WriteLine();
    }
}

