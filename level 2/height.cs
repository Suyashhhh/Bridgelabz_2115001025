
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter age of Amar: ");
        int amarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter height of Amar (in cm): ");
        double amarHeight = double.Parse(Console.ReadLine());

        Console.Write("Enter age of Akbar: ");
        int akbarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter height of Akbar (in cm): ");
        double akbarHeight = double.Parse(Console.ReadLine());

        Console.Write("Enter age of Anthony: ");
        int anthonyAge = int.Parse(Console.ReadLine());
        Console.Write("Enter height of Anthony (in cm): ");
        double anthonyHeight = double.Parse(Console.ReadLine());

        int youngestAge = Math.Min(Math.Min(amarAge, akbarAge), anthonyAge);
        double tallestHeight = Math.Max(Math.Max(amarHeight, akbarHeight), anthonyHeight);

        if (youngestAge == amarAge)
            Console.WriteLine("Youngest friend is Amar.");
        else if (youngestAge == akbarAge)
            Console.WriteLine("Youngest friend is Akbar.");
        else
            Console.WriteLine("Youngest friend is Anthony.");

        if (tallestHeight == amarHeight)
            Console.WriteLine("Tallest friend is Amar.");
        else if (tallestHeight == akbarHeight)
            Console.WriteLine("Tallest friend is Akbar.");
        else
            Console.WriteLine("Tallest friend is Anthony.");
    }
}

