using System;
using System.Text.RegularExpressions;

public class IPAddressValidator
{
    public bool IsValidIPv4(string ipAddress)
    {
        string pattern = @"^(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)){3}$";
        return Regex.IsMatch(ipAddress, pattern);
    }
}

public class Program
{
    public static void Main()
    {
        IPAddressValidator validator = new IPAddressValidator();

        string[] testIPs = {
            "192.168.1.1",
            "255.255.255.255",
            "0.0.0.0",
            "256.100.50.25",
            "123.045.067.089"
        };

        Console.WriteLine("IP Address Validation Results:");
        foreach (string ip in testIPs)
        {
            bool isValid = validator.IsValidIPv4(ip);
            Console.WriteLine($"{ip} → {(isValid ? "Valid" : "Invalid")}");
        }
    }
}

