using System;
class CarRental
{
    public string customerName, carModel;
    public int rentalDays;
    public double totalCost;

    public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        totalCost = rentalDays*5000; // assuming 5000 rupees per day
    }

    static void Main()
    {
        CarRental rental = new CarRental("akash", "toyota altas", 5);
        Console.WriteLine($"total cost: {rental.totalCost}");
    }
}
