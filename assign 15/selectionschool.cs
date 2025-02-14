using System;

class Program
{
    static void SelectionSort(int[] scores)
    {
        int n = scores.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIndex])
                    minIndex = j;
            }
            (scores[i], scores[minIndex]) = (scores[minIndex], scores[i]);
        }
    }

    static void Main()
    {
        Console.Write("enter number of students: ");
        int n = int.Parse(Console.ReadLine());
        int[] scores = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"enter score {i + 1}: ");
            scores[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("before sorting:");
        foreach (int score in scores) Console.Write(score + " ");
        Console.WriteLine();

        SelectionSort(scores);

        Console.WriteLine("after sorting:");
        foreach (int score in scores) Console.Write(score + " ");
        Console.WriteLine();
    }
}
