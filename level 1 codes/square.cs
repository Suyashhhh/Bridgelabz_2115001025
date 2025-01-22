using System;

class Program
{
    public static void Main(string[] args) 
    {
		double perimeter;
		Console.Write("enter perimeter ");
		perimeter=Convert.ToDouble(Console.ReadLine());
		double side= perimeter/4;
		Console.WriteLine($"the length of the side is {side} whose perimeter is {perimeter}");
    }
}

