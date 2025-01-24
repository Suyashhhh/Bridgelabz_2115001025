using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the number of persons: ");
        int n = int.Parse(Console.ReadLine());
        
        double[] weights = new double[n];
        double[] heights = new double[n];
        double[] bmis = new double[n];
        string[] statuses = new string[n];
        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter the weight (in kg) of person {i + 1}: ");
            weights[i] = double.Parse(Console.ReadLine());
            
            Console.Write($"Enter the height (in meters) of person {i + 1}: ");
            heights[i] = double.Parse(Console.ReadLine());
            
            bmis[i] = weights[i] / (heights[i] * heights[i]);

            if (bmis[i] < 18.5)
                statuses[i] = "Underweight";
            else if (bmis[i] >= 18.5 && bmis[i] < 24.9)
                statuses[i] = "Normal weight";
            else if (bmis[i] >= 25 && bmis[i] < 29.9)
                statuses[i] = "Overweight";
            else
                statuses[i] = "Obese";
        }

        Console.WriteLine("\nPerson | Height (m) | Weight (kg) | BMI | Status");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{i + 1} | {heights[i]:0.00} | {weights[i]:0.00} | {bmis[i]:0.00} | {statuses[i]}");
        }
    }
}

