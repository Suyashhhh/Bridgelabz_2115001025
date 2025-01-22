using System;
class Program
{
    public static void Main(string[] args) 
    {
		int variable1,variable2;
		Console.Write("enter first number");
		variable1=Convert.ToInt32(Console.ReadLine());
		Console.Write("enter second number");
		variable2=Convert.ToInt32(Console.ReadLine());
		int addition=variable1+variable2;
		int subtraction=variable1-variable2;
		int multiplication=variable1*variable2;
		double division=variable1/variable2;
		Console.WriteLine($"the addition , subtraction, multiplication adn division value of 2 numbers {variable1} and {variable2} is {addition},{subtraction},{multiplication}, and{division}");
    }
}

