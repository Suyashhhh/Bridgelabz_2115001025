using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());
        double[] trigValues = calculateTrigonometricFunctions(angle);
        Console.WriteLine($"Sine: {trigValues[0]:F4}, Cosine: {trigValues[1]:F4}, Tangent: {trigValues[2]:F4}");
    }
    public static double[] calculateTrigonometricFunctions(double angle)
    {
        double radians = angle * Math.PI / 180; // Convert angle from degrees to radians
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);
        return new double[] { sine, cosine, tangent };
    }
}

