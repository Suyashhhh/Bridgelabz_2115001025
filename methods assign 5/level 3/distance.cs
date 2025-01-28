using System;
public class EuclideanDistance {

    public static double FindEuclideanDistance(double x1, double y1, double x2, double y2) {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    public static double[] FindLineEquation(double x1, double y1, double x2, double y2) {
        double m = (y2 - y1) / (x2 - x1);
        double b = y1 - m * x1;
        return new double[] { m, b };
    }

    public static void Main() {
        Console.Write("enter x1, y1: ");
        string[] point1 = Console.ReadLine().Split(',');
        double x1 = double.Parse(point1[0]);
        double y1 = double.Parse(point1[1]);

        Console.Write("enter x2, y2: ");
        string[] point2 = Console.ReadLine().Split(',');
        double x2 = double.Parse(point2[0]);
        double y2 = double.Parse(point2[1]);

        double distance = FindEuclideanDistance(x1, y1, x2, y2);
        double[] equation = FindLineEquation(x1, y1, x2, y2);

        Console.WriteLine($"euclidean distance: {distance}");
        Console.WriteLine($"line equation: y = {equation[0]}x + {equation[1]}");
    }
} 

