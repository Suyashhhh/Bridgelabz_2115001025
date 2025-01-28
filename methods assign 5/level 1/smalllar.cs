using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int number3 = int.Parse(Console.ReadLine());
        int[] result = FindSmallestAndLargest(number1, number2, number3);
        Console.WriteLine($"The smallest number is {result[0]} and the largest number is {result[1]}.");
    }
    static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int smallest = number1;
        int largest = number1;
        if (number2 < smallest) smallest = number2;
        if (number3 < smallest) smallest = number3;
        if (number2 > largest) largest = number2;
        if (number3 > largest) largest = number3;
        return new int[] { smallest, largest };
    }
}

