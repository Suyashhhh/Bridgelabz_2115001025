using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        if (numberOfChildren > 0)
        {
            int chocolatesPerChild = numberOfChocolates / numberOfChildren;
            int remainingChocolates = numberOfChocolates % numberOfChildren;

            Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild} and the number of remaining chocolates is {remainingChocolates}.");
        }
        else
        {
            Console.WriteLine("The number of children must be greater than 0.");
        }
    }
}

