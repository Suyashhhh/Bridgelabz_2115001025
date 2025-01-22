using System;
class Program
{
    public static void Main(string[] args)
    {
        double radius = 6378.0;
		double volume= (4/3)*Math.PI*Math.Pow(radius,3);
        Console.WriteLine($"The volume of earth in cubic kilometer is {volume} and cubic miles is {volume*0.6}");
    }
}

