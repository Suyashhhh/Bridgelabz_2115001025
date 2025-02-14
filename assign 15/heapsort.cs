using System;

class Program
{
    static void HeapSort(decimal[] salaries)
    {
        int n = salaries.Length;
        for (int i = n / 2 - 1; i >= 0; i--) Heapify(salaries, n, i);
        for (int i = n - 1; i > 0; i--)
        {
            (salaries[0], salaries[i]) = (salaries[i], salaries[0]);
            Heapify(salaries, i, 0);
        }
    }

    static void Heapify(decimal[] salaries, int n, int i)
    {
        int largest = i, left = 2 * i + 1, right = 2 * i + 2;
        if (left < n && salaries[left] > salaries[largest]) largest = left;
        if (right < n && salaries[right] > salaries[largest]) largest = right;
        if (largest != i)
        {
            (salaries[i], salaries[largest]) = (salaries[largest], salaries[i]);
            Heapify(salaries, n, largest);
        }
    }

    static void Main()
    {
        Console.Write("enter number of applicants: ");
        int n = int.Parse(Console.ReadLine());
        decimal[] salaries = new decimal[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"enter expected salary {i + 1}: ");
            salaries[i] = decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine("before sorting:");
        foreach (decimal salary in salaries) Console.Write(salary + " ");
        Console.WriteLine();

        HeapSort(salaries);

        Console.WriteLine("after sorting:");
        foreach (decimal salary in salaries) Console.Write(salary + " ");
        Console.WriteLine();
    }
}
