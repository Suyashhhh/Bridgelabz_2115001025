using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter 1st number: ");
		int number1 = int.Parse(Console.ReadLine());
		Console.Write("enter 2nd number");
		int number2= int.Parse(Console.ReadLine());
		Console.Write("enter 3rd number");
		int number3= int.Parse(Console.ReadLine());
		Console.WriteLine($"is the first number largest :{number1>number2 && number1>number3}");
		Console.WriteLine($"is the second number largest :{number2>number1 && number2>number3}");
		Console.WriteLine($"is the third number largest :{number3>number1 && number3>number2}");

    }
}

