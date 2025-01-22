using System;
class Program
{
    public static void Main(string[] args) 
    {
		double fee;
		Console.Write("enter the fee amount");
		fee = Convert.ToDouble(Console.ReadLine());
		double DiscountPercent;
		Console.Write("enter discount percent");
		DiscountPercent= Convert.ToDouble(Console.ReadLine());
		double discount = fee * DiscountPercent / 100;
        double finalFee = fee - discount;
		Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is {finalFee}");
    }
}

