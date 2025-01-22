using System;
class Program
{
    public static void Main(string[] args)
    {
        int costprice = 129;
        int sellingprice = 191;

        int profit = sellingprice - costprice;
        double profitpercentage = (double)profit / costprice * 100;

        Console.WriteLine($@"
The Cost Price is INR {costprice} and Selling Price is INR {sellingprice}
The Profit is INR {profit} and the Profit Percentage is {profitpercentage:F2}%
");
    }
}

