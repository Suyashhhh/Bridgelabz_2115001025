using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 3, 20, 4, 1, 0 };
        Console.WriteLine(FindPeak(arr));
    }

    static int FindPeak(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int mid = (left + right) / 2;
            
            if (arr[mid] > arr[mid + 1])
                right = mid;
            else
                left = mid + 1;
        }

        return arr[left];
    }
}
