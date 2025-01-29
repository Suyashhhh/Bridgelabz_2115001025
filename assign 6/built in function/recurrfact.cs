using System;
class Program
{
    static int GetInput()
    {
        Console.Write("Enter a number: ");
        return int.Parse(Console.ReadLine());
    }

    static int CalculateFactorial(int num)
    {
        if (num <= 1) return 1;
        return num * CalculateFactorial(num - 1);
    }

    static void DisplayResult(int factorial)
    {
        Console.WriteLine("The factorial is: " + factorial);
    }

    static void Main()
    {
        int input = GetInput();
        int result = CalculateFactorial(input);
        DisplayResult(result);
    }
}

