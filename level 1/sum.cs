using System;
class Program
{
    static void Main()
    {
		double total= 0.0;
		double num;
		do
		{
			Console.WriteLine("enter a number");
			num = double.Parse(Console.ReadLine());
			total+=num;
		}
		while(num!=0);
		Console.WriteLine($"the sum of numbers is {total}");
		
    }
}

