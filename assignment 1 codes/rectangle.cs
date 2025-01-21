using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the length of the rectangle: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Enter the width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());
        double perimeter = 2 * (length + width);
        Console.WriteLine("Perimeter of the rectangle: {0}", perimeter);
    }
}
