using System;

class Program
{
    static void Main()
    {
        int[] arr = { 3, 7, 2, -5, 8, -2, 10 };
        foreach (int num in arr)
            if (num < 0)
            {
                Console.WriteLine(num);
                return;
            }
    }
}
