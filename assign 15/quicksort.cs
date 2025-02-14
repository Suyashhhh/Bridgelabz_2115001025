using System;

class Program
{
    static void QuickSort(decimal[] prices, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(prices, left, right);
            QuickSort(prices, left, pivotIndex - 1);
            QuickSort(prices, pivotIndex + 1, right);
        }
    }

    static int Partition(decimal[] prices, int left, int right)
    {
        decimal pivot = prices[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (prices[j] < pivot)
            {
                i++;
                (prices[i], prices[j]) = (prices[j], prices[i]);
            }
        }
        (prices[i + 1], prices[right]) = (prices[right], prices[i + 1]);
        return i + 1;
    }

    static void Main()
    {
        Console.Write("enter number of products: ");
        int n = int.Parse(Console.ReadLine());
        decimal[] prices = new decimal[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"enter price of product {i + 1}: ");
            prices[i] = decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine("before sorting:");
        foreach (decimal price in prices) Console.Write(price + " ");
        Console.WriteLine();

        QuickSort(prices, 0, n - 1);

        Console.WriteLine("after sorting:");
        foreach (decimal price in prices) Console.Write(price + " ");
        Console.WriteLine();
    }
}
