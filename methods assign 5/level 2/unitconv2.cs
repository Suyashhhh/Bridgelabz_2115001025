using System;

class UnitConvertor
{
    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3;
        return yards * yards2feet;
    }

    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    public static double ConvertInchesToCentimeters(double inches)
    {
        double inches2cm = 2.54;
        return inches * inches2cm;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("10 yards to feet: " + UnitConvertor.ConvertYardsToFeet(10));
        Console.WriteLine("10 feet to yards: " + UnitConvertor.ConvertFeetToYards(10));
        Console.WriteLine("10 meters to inches: " + UnitConvertor.ConvertMetersToInches(10));
        Console.WriteLine("10 inches to meters: " + UnitConvertor.ConvertInchesToMeters(10));
        Console.WriteLine("10 inches to centimeters: " + UnitConvertor.ConvertInchesToCentimeters(10));
    }
}

