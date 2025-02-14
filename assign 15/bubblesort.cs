
using System;

class Program
{
    static void BubbleSort(int[] marks)
    {
        int n = marks.Length;
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < n - 1; i++)
            {
                if (marks[i] > marks[i + 1])
                {
                    int temp = marks[i];
                    marks[i] = marks[i + 1];
                    marks[i + 1] = temp;
                    swapped = true;
                }
            }
        } while (swapped);
    }

    static void Main()
    {
        Console.Write("enter number of students: ");
        int n = int.Parse(Console.ReadLine());
        int[] marks = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"enter mark {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("before sorting:");
        foreach (int mark in marks) Console.Write(mark + " ");
        Console.WriteLine();

        BubbleSort(marks);

        Console.WriteLine("after sorting:");
        foreach (int mark in marks) Console.Write(mark + " ");
        Console.WriteLine();
    }
}

