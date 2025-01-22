using System;
class Program
{
    static void Main()
    {
		int variable1,variable2;
		Console.Write("enter first number");
		variable1=Convert.ToInt32(Console.ReadLine());
		Console.Write("enter second number");
		variable2=Convert.ToInt32(Console.ReadLine());
		variable1 = variable1 + variable2;
        variable2 = variable1 - variable2;
        variable1 = variable1 - variable2;
		Console.WriteLine($"the swapped numbers are {variable1} and {variable2}");

    }
}

