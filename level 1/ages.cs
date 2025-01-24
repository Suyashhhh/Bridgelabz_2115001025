
using System;
class Program
{
    static void Main()
    {
        int[] ages = new int[10];
        Console.WriteLine("Enter the ages of 10 students:");

        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Age of student {i + 1}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[i] < 0)
            {
                Console.WriteLine($"Student {i + 1} has an invalid age: {ages[i]}.");
            }
            else if (ages[i] >= 18)
            {
                Console.WriteLine($"The student with the age {ages[i]} can vote.");
            }
            else
            {
                Console.WriteLine($"The student with the age {ages[i]} cannot vote.");
            }
        }
    }
}

