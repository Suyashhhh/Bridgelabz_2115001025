using System;

class Program
{
    static int FindFirstOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, result = -1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                right = mid - 1;
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return result;
    }

    static int FindLastOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, result = -1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                left = mid + 1;
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return result;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 2, 2, 3, 4, 4, 5 };
        int target = 2;
        int first = FindFirstOccurrence(arr, target);
        int last = FindLastOccurrence(arr, target);
        Console.WriteLine("first occurrence: " + first);
        Console.WriteLine("last occurrence: " + last);
    }
}
