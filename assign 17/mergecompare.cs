using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };

        foreach (int size in sizes)
        {
            int[] data1 = GenerateRandomData(size);
            int[] data2 = (int[])data1.Clone();
            int[] data3 = (int[])data1.Clone();

            Console.WriteLine($"\ndataset size: {size}");

            Stopwatch sw = new Stopwatch();

            sw.Start();
            BubbleSort(data1);
            sw.Stop();
            Console.WriteLine($"bubble sort: {sw.Elapsed.TotalMilliseconds} ms");

            sw.Restart();
            MergeSort(data2, 0, size - 1);
            sw.Stop();
            Console.WriteLine($"merge sort: {sw.Elapsed.TotalMilliseconds} ms");

            sw.Restart();
            QuickSort(data3, 0, size - 1);
            sw.Stop();
            Console.WriteLine($"quick sort: {sw.Elapsed.TotalMilliseconds} ms");
        }
    }

    static int[] GenerateRandomData(int size)
    {
        Random rand = new Random();
        int[] data = new int[size];
        for (int i = 0; i < size; i++) data[i] = rand.Next(1, size);
        return data;
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left >= right) return;
        int mid = left + (right - left) / 2;
        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);
        Merge(arr, left, mid, right);
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] leftArr = new int[mid - left + 1];
        int[] rightArr = new int[right - mid];

        Array.Copy(arr, left, leftArr, 0, leftArr.Length);
        Array.Copy(arr, mid + 1, rightArr, 0, rightArr.Length);

        int i = 0, j = 0, k = left;
        while (i < leftArr.Length && j < rightArr.Length)
            arr[k++] = leftArr[i] <= rightArr[j] ? leftArr[i++] : rightArr[j++];

        while (i < leftArr.Length) arr[k++] = leftArr[i++];
        while (j < rightArr.Length) arr[k++] = rightArr[j++];
    }

    static void QuickSort(int[] arr, int left, int right)
    {
        if (left >= right) return;
        int pivot = Partition(arr, left, right);
        QuickSort(arr, left, pivot - 1);
        QuickSort(arr, pivot + 1, right);
    }

    static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right], i = left - 1;
        for (int j = left; j < right; j++)
            if (arr[j] <= pivot)
                (arr[++i], arr[j]) = (arr[j], arr[i]);

        (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);
        return i + 1;
    }
}
