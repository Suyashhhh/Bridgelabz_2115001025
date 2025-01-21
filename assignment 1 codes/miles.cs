using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the distance in kilometers: ");
        double kilometers = double.Parse(Console.ReadLine());
        double miles = kilometers * 0.621371;
        Console.WriteLine("Distance in miles: {0}", miles);
    }
}
