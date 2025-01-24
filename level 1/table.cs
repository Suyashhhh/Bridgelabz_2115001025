
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to generate its multiplication table: ");
        int number = int.Parse(Console.ReadLine());

        int[] multiplicationTable = new int[10];

        for (int i = 0; i < multiplicationTable.Length; i++)
        {
            multiplicationTable[i] = number * (i + 1);
        }

        for (int i = 0; i < multiplicationTable.Length; i++)
        {
            Console.WriteLine($"{number} * {i + 1} = {multiplicationTable[i]}");
        }
    }
}

