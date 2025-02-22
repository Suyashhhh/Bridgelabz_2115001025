using System;
using System.Text.RegularExpressions;

public class UsernameValidator
{
    public bool IsValidUsername(string username)
    {
        string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        return Regex.IsMatch(username, pattern);
    }
}

public class Program
{
    public static void Main()
    {
        IsValidUsername validator = new IsValidUsername();

        Console.WriteLine(validator.IsValidLicensePlate("suyash_420")); // true
        Console.WriteLine(validator.IsValidLicensePlate("420suyash")); // false
        Console.WriteLine(validator.IsValidLicensePlate("killjoy")); // true
    }
}

