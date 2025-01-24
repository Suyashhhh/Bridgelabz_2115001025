
using System;
class Program
{
    static void Main()
    {
        double[] heights = new double[11]; double sum = 0.0;
        Console.WriteLine("Enter the heights of 11 players:");
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Height of player {i + 1}: ");
            heights[i] = double.Parse(Console.ReadLine());
            sum += heights[i];
        }
        double mean = sum / 11;
        Console.WriteLine($"The mean height of the football team is: {mean}");
    }
}
