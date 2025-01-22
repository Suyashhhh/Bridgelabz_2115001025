using System;
class Program
{
    public static void Main(string[] args) 
    {
		double height;
		Console.Write("enter yyour height");
		height=Convert.ToDouble(Console.ReadLine());
		double ininches = height/2.54;
		double infeet = ininches/12.0;
		Console.WriteLine($"your height in cm is {height} while in feet is {infeet} and in inches is {ininches}");
    }
}

