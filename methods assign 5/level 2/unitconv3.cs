using System;

class UnitConvertor
{
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("100 fahrenheit to celsius: " + UnitConvertor.ConvertFahrenheitToCelsius(100));
        Console.WriteLine("37.5 celsius to fahrenheit: " + UnitConvertor.ConvertCelsiusToFahrenheit(37.5));
        Console.WriteLine("150 pounds to kilograms: " + UnitConvertor.ConvertPoundsToKilograms(150));
        Console.WriteLine("68 kilograms to pounds: " + UnitConvertor.ConvertKilogramsToPounds(68));
        Console.WriteLine("10 gallons to liters: " + UnitConvertor.ConvertGallonsToLiters(10));
        Console.WriteLine("50 liters to gallons: " + UnitConvertor.ConvertLitersToGallons(50));
    }
}

