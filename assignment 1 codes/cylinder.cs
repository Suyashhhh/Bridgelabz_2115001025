using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the radius of the cylinder: ");
        double radius = double.Parse(Console.ReadLine());
        Console.Write("Enter the height of the cylinder: ");
        double height = double.Parse(Console.ReadLine());
        double volume = Math.PI * radius * radius * height;
        Console.WriteLine("Volume of the cylinder: {0}", volume);
    }
}
