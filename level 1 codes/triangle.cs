using System;
class Program
{
    public static void Main(string[] args) 
    {
		double base1,height;
		Console.Write("enter base ");
		base1=Convert.ToDouble(Console.ReadLine());
		Console.Write("enter height");
		height=Convert.ToDouble(Console.ReadLine());
		double areaincm = 0.5*base1*height;
		double areaininch = areaincm*0.155;
		Console.WriteLine($"the area of triangle in squarecm is {areaincm} and in squareinches is {areaininch}");
    }
}

