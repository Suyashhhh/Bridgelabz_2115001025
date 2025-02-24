using System;
using System.Reflection;

public class Configuration
{
    private static string API_KEY = "DEFAULT_KEY";

    public static void DisplayKey()
    {
        Console.WriteLine($"current API_KEY: {API_KEY}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Configuration.DisplayKey();

        Type type = typeof(Configuration);
        FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        if (field != null)
        {
            field.SetValue(null, "UPDATED_KEY_123");
        }

        Configuration.DisplayKey();
    }
}
