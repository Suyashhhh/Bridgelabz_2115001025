using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the starting city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter the via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter the destination city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter the distance from the starting city to the via city (in miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the distance from the via city to the destination city (in miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the total time taken for the journey (in hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        Console.WriteLine($"The results of the trip are: {totalDistance} miles, {timeTaken} hours, and {averageSpeed} miles per hour.");
    }
}

