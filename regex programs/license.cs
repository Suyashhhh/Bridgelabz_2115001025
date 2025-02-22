using System;
using System.Text.RegularExpressions;

public class LicensePlateValidator
{
    public bool IsValidLicensePlate(string plate)
    {
        string pattern = @"^[A-Z]{2}\d{4}$";
        return Regex.IsMatch(plate, pattern);
    }
}

public class Program
{
    public static void Main()
    {
        LicensePlateValidator validator = new LicensePlateValidator();

        Console.WriteLine(validator.IsValidLicensePlate("AB1234")); // true
        Console.WriteLine(validator.IsValidLicensePlate("A12345")); // false
        Console.WriteLine(validator.IsValidLicensePlate("XY9999")); // true

    }
}

