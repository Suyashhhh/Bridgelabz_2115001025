using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter weight in kilograms: ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter height in centimeters: ");
        double heightCm = double.Parse(Console.ReadLine());

        double heightM = heightCm / 100;
        double bmi = weight / (heightM * heightM);

        Console.WriteLine($"BMI: {bmi:F2}");

        if (bmi < 18.5)
        {
            Console.WriteLine("Underweight");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("Normal weight");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }
    }
}