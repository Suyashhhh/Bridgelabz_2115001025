using System;
using System.Collections.Generic;

class Program
{
    static int FindStartingPump(int[] petrol, int[] distance)
    {
        int n = petrol.Length, start = 0, deficit = 0, balance = 0;

        for (int i = 0; i < n; i++)
        {
            balance += petrol[i] - distance[i];
            if (balance < 0)
            {
                start = i + 1;
                deficit += balance;
                balance = 0;
            }
        }
        return balance + deficit >= 0 ? start : -1;
    }

    static void Main()
    {
        Console.Write("enter number of petrol pumps: ");
        int n = int.Parse(Console.ReadLine());
        int[] petrol = new int[n], distance = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"enter petrol at pump {i + 1}: ");
            petrol[i] = int.Parse(Console.ReadLine());
            Console.Write($"enter distance to next pump {i + 1}: ");
            distance[i] = int.Parse(Console.ReadLine());
        }

        int start = FindStartingPump(petrol, distance);

        Console.WriteLine(start == -1 ? "no valid starting pump" : "start at pump " + (start + 1));
    }
}
