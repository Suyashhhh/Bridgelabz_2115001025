using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the unit price ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        double totalPrice = unitPrice * quantity;

        Console.WriteLine($"The total purchase price is INR {totalPrice} if the quantity is {quantity} and the unit price is INR {unitPrice}");
    }
}

