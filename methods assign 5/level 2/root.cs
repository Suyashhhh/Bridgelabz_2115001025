using System;

public class Quadratic {
    public double[] FindRoots(double a, double b, double c) {
        double delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta > 0) {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        } else if (delta == 0) {
            double root = -b / (2 * a);
            return new double[] { root };
        }
        return new double[0]; 
    }

    public static void Main() {
        Quadratic quadratic = new Quadratic();
        Console.WriteLine("Enter the values for a, b, and c:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double[] roots = quadratic.FindRoots(a, b, c);

        if (roots.Length == 0) {
            Console.WriteLine("No real roots.");
        } else if (roots.Length == 1) {
            Console.WriteLine($"One root: {roots[0]}");
        } else {
            Console.WriteLine($"Two roots: {roots[0]} and {roots[1]}");
        }
    }
}

