
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the number of persons: ");
        int number = int.Parse(Console.ReadLine());
        
        double[][] personData = new double[number][3];
        string[] weightStatus = new string[number];

        for (int i = 0; i < number; i++)
        {
            double weight, height;
            do
            {
                Console.Write($"Enter the weight (in kg) of person {i + 1}: ");
                weight = double.Parse(Console.ReadLine());
            } while (weight <= 0);

            do
            {
                Console.Write($"Enter the height (in meters) of person {i + 1}: ");
                height = double.Parse(Console.ReadLine());
            } while (height <= 0);

            personData[i][0] = weight;
            personData[i][1] = height;
            personData[i][2] = weight / (height * height);

            if (personData[i][2] < 18.5)
                weightStatus[i] = "Underweight";
            else if (personData[i][2] >= 18.5 && personData[i][2] < 24.9)
                weightStatus[i] = "Normal weight";
            else if (personData[i][2] >= 25 && personData[i][2] < 29.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        Console.WriteLine("\nPerson | Height (m) | Weight (kg) | BMI | Status");
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"{i + 1} | {personData[i][1]:0.00} | {personData[i][0]:0.00} | {personData[i][2]:0.00} | {weightStatus[i]}");
        }
    }
}

