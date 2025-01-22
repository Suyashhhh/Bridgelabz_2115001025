using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first side of the triangle (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second side of the triangle (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third side of the triangle (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        double perimeter = side1 + side2 + side3;
        double distanceToRun = 5000;

        double rounds = distanceToRun / perimeter;

        Console.WriteLine($"The total number of rounds the athlete will run is {rounds:F2} to complete 5 km.");
    }
}

