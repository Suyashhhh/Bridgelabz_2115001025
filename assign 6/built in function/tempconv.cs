using System;

class Program
{
    static double getinput(string prompt)
    {
        Console.Write(prompt);
        return double.Parse(Console.ReadLine());
    }

    static double fahrenheittocelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double celsiustofahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static void displayresult(double result, string scale)
    {
        Console.WriteLine("Converted temperature: " + result + " " + scale);
    }

    static void Main()
    {
        double fahrenheit = getinput("enter temperature in fahrenheit: ");
        double celsius = getinput("enter temperature in celsius: ");

        double celsiusResult = fahrenheittocelsius(fahrenheit);
        double fahrenheitResult = celsiustofahrenheit(celsius);

        displayresult(celsiusResult, "Celsius");
        displayresult(fahrenheitResult, "Fahrenheit");
    }
}

