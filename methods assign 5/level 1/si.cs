
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter Principal: ");
        int principal = int.Parse(Console.ReadLine());
        Console.Write("Enter Rate: ");
        float rate =  int.Parse(Console.ReadLine());
        Console.Write("Enter Time: ");
        int time = int.Parse(Console.ReadLine());
        float simpleInterest = CalculateSimpleInterest(principal, rate, time);
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    }
    static float CalculateSimpleInterest(int principal, float rate, int time) => principal * rate * time / 100;
}

