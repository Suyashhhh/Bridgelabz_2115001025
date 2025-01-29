using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        int maxCount = 0;
        char mostFrequentChar = ' ';
        for (int i = 0; i < input.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < input.Length; j++)
            {
                if (input[i] == input[j])
                {
                    count++;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
                mostFrequentChar = input[i];
            }
        }
        Console.WriteLine($"Most Frequent Character: '{mostFrequentChar}'");
    }
}

