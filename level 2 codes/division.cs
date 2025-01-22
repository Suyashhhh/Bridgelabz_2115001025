using System;
class Program
{
    static void Main()
    {
		int number1,number2;
		Console.Write("enter 1st number");
		number1=Convert.ToInt32(Console.ReadLine());
		Console.Write("enter 2nd number");
		number2=Convert.ToInt32(Console.ReadLine());
		int quo = number1/number2;
		int remainder=number1%number2;
		Console.WriteLine($"the quotient is {quo} and remainder is {remainder} of the numbers {number1} and {number2}");
	}
}