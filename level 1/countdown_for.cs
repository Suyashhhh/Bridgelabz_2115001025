using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the countdown starting value: ");
        int counter = int.Parse(Console.ReadLine());

        for (int i = counter; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Rocket Launched!");
    }
}



