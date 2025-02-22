using System;
using System.Text.RegularExpressions;

public class HexColorValidator
{
    public bool IsValidHexColor(string colorCode)
    {
        string pattern = @"^#([A-Fa-f0-9]{6})$";
        return Regex.IsMatch(colorCode, pattern);
    }
}

public class Program
{
    public static void Main()
    {
        HexColorValidator validator = new HexColorValidator();

        Console.WriteLine(validator.IsValidHexColor("#FFA500")); // true
        Console.WriteLine(validator.IsValidHexColor("#ff4500")); // true
        Console.WriteLine(validator.IsValidHexColor("#123"));    // false
    }
}
