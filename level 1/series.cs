using System;
class Program
{
    static void Main()
    {
		Console.Write("enter a number");
		int number = int.Parse(Console.ReadLine());

		if(number > 0)
		{
			int sum = number*(number+1)/2;
			Console.WriteLine($"the sum of {number} natural numbers is : {sum}");
		}
		else
		{
			Console.WriteLine("number is not natural");
		}	
    }
}

