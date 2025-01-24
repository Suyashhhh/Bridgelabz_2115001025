
using System;
class Program
{
    static void Main()
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3], heights = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter the age of {friends[i]}: ");
            ages[i] = int.Parse(Console.ReadLine());
            Console.Write($"Enter the height of {friends[i]}: ");
            heights[i] = int.Parse(Console.ReadLine());
        }

        int youngestAge = ages[0], tallestHeight = heights[0];
        string youngestFriend = friends[0], tallestFriend = friends[0];

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < youngestAge)
            {
                youngestAge = ages[i];
                youngestFriend = friends[i];
            }
            if (heights[i] > tallestHeight)
            {
                tallestHeight = heights[i];
                tallestFriend = friends[i];
            }
        }

        Console.WriteLine($"The youngest friend is {youngestFriend} with age {youngestAge}.");
        Console.WriteLine($"The tallest friend is {tallestFriend} with height {tallestHeight}.");
    }
}

