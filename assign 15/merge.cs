
using System;

class Program
{
    static void MergeSort(decimal[] prices, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(prices, left, mid);
            MergeSort(prices, mid + 1, right);
            Merge(prices, left, mid, right);
        }
    }

    static void Merge(decimal[] prices, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        decimal[] leftArr = new decimal[n1];
        decimal[] rightArr = new decimal[n2];

        for (int i = 0; i < n1; i++) leftArr[i] = prices[left + i];
        for (int i = 0; i < n2; i++) rightArr[i] = prices[mid + 1 + i];

        int i1 = 0, i2 = 0, k = left;
        while (i1 < n1 && i2 < n2)
        {
            if (leftArr[i1] <= rightArr[i2])
                prices[k++] = leftArr[i1++];
            else
                prices[k++] = rightArr[i2++];
        }
        while (i1 < n1) prices[k++] = leftArr[i1++];
        while (i2 < n2) prices[k++] = rightArr[i2++];
    }

    static void Main()
    {
        Console.Write("enter number of books: ");
        int n = int.Parse(Console.ReadLine());
        decimal[] prices = new decimal[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"enter price of book {i + 1}: ");
            prices[i] = decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine("before sorting:");
        foreach (decimal price in prices) Console.Write(price + " ");
        Console.WriteLine();

        MergeSort(prices, 0, n - 1);

        Console.WriteLine("after sorting:");
        foreach (decimal price in prices) Console.Write(price + " ");
        Console.WriteLine();
    }
}

