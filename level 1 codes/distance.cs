using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());
        double distanceInYards = distanceInFeet / 3.0;
        double distanceInMiles = distanceInFeet / 5280.0;
        Console.WriteLine($"The distance is {distanceInYards} yards or {distanceInMiles} miles.");

        Console.Write("Enter your height in cm: ");
        double heightInCm = Convert.ToDouble(Console.ReadLine());
        double heightInFeet = Math.Floor(heightInCm / 30.48);
        double remainingInches = Math.Round((heightInCm / 2.54) % 12);
        Console.WriteLine($"Your height in cm is {heightInCm} cm, in feet is {heightInFeet} ft, and in inches is {remainingInches} inches.");
    }
}

