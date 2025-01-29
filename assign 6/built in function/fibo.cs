using System;
class Program
{
    static void GenerateFibonacci(int terms)
    {
        int a = 0, b = 1;
        Console.Write(a + " " + b + " ");
        for (int i = 2; i < terms; i++)
        {
            int next = a + b;
            Console.Write(next + " ");
            a = b;
            b = next;
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int terms = int.Parse(Console.ReadLine());

        GenerateFibonacci(terms);
    }
}

