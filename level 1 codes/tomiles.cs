using System;
class Program
{
    public static void Main(string[] args) 
    {
        double km;
        Console.Write("Enter the distance in kilometers: ");
        km = Convert.ToDouble(Console.ReadLine());
        double miles = km / 1.6;
        Console.WriteLine($"The total miles is {miles:F2} mile for the given {km} km");
    }
}

