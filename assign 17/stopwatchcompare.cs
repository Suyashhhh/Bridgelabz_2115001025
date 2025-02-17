using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };
        int target = -1; 

        foreach (int size in sizes)
        {
            int[] data = GenerateSortedData(size);

            Stopwatch sw = new Stopwatch();

            sw.Start();
            int linearIndex = LinearSearch(data, target);
            sw.Stop();
            Console.WriteLine($"linear search ({size} elements): {sw.Elapsed.TotalMilliseconds} ms");

            sw.Restart();
            int binaryIndex = BinarySearch(data, target);
            sw.Stop();
            Console.WriteLine($"binary search ({size} elements): {sw.Elapsed.TotalMilliseconds} ms");
        }
    }

    static int[] GenerateSortedData(int size)
    {
        int[] data = new int[size];
        for (int i = 0; i < size; i++) data[i] = i;
        return data;
    }

    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == target) return i;
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target) return mid;
            if (arr[mid] < target) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }
}
