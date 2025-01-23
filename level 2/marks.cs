
using System;
class Program
{
    static void Main()
    {
        int physics, chemistry, maths;
        Console.WriteLine("Enter physics marks:");
        physics = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter chemistry marks:");
        chemistry = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter maths marks:");
        maths = int.Parse(Console.ReadLine());

        int average = (physics + chemistry + maths) / 3;

        if (average >= 80)
        {
            Console.WriteLine("Level 4, above agency normalized standards");
        }
        else if (average >= 70 && average <= 79)
        {
            Console.WriteLine("Level 3 at agency normalized standards");
        }
        else if (average >= 60 && average <= 69)
        {
            Console.WriteLine("Level 2, below but approaching agency");
        }
        else if (average >= 50 && average <= 59)
        {
            Console.WriteLine("Level 1, well below agency normalized standards");
        }
        else if (average >= 40 && average <= 49)
        {
            Console.WriteLine("Level 1- too below agency standards");
        }
        else
        {
            Console.WriteLine("Remedial standards");
        }
    }
}

