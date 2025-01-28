using System;

public class CollinearPoints {

    public static bool ArePointsCollinearBySlope(double x1, double y1, double x2, double y2, double x3, double y3) {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);
        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    public static bool ArePointsCollinearByArea(double x1, double y1, double x2, double y2, double x3, double y3) {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return area == 0;
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

        Console.Write("enter x3, y3: ");
        string[] point3 = Console.ReadLine().Split(',');
        double x3 = double.Parse(point3[0]);
        double y3 = double.Parse(point3[1]);

        bool collinearBySlope = ArePointsCollinearBySlope(x1, y1, x2, y2, x3, y3);
        bool collinearByArea = ArePointsCollinearByArea(x1, y1, x2, y2, x3, y3);

        if (collinearBySlope && collinearByArea) {
            Console.WriteLine("the points are collinear");
        } else {
            Console.WriteLine("the points are not collinear");
        }
    }
} 

