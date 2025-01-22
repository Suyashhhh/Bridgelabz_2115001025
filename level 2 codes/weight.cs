using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        double weightInKilograms = weightInPounds * 2.2;

        Console.WriteLine($"The weight of the person in pounds is {weightInPounds} and in kg is {weightInKilograms}.");
    }
}



