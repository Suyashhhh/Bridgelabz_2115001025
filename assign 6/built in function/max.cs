using System;
class Program
{
    static int GetInput(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    static int FindMaximum(int num1, int num2, int num3)
    {
        int max = num1;
        if (num2 > max) max = num2;
        if (num3 > max) max = num3;
        return max;
    }

    static void Main()
    {
        int num1 = GetInput("Enter the first number: ");
        int num2 = GetInput("Enter the second number: ");
        int num3 = GetInput("Enter the third number: ");

        int max = FindMaximum(num1, num2, num3);
        Console.WriteLine("The maximum number is: " + max);
    }
}

