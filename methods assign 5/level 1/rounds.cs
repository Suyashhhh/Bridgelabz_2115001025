
using System;
class Program{
	static void Main(){
		Console.Write("enter length of side 1 in meters");
		int side1 = int.Parse(Console.ReadLine());
		Console.Write("enter length of side 2 in meters");
		int side2 = int.Parse(Console.ReadLine());
		Console.Write("enter length of side 3 in meters");
		int side3 = int.Parse(Console.ReadLine());
		int perimeter = side1+side2+side3;
		int rounds= numberofrounds(perimeter);
		Console.WriteLine($"distance will be {perimeter} and number of rounds : {rounds}");
		static int numberofrounds(int perimeter){
			return 5000/perimeter;
		}
	}
}

