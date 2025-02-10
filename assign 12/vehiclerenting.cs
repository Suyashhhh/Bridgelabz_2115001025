using System;
using System.Collections.Generic;

interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    protected Vehicle(string number, string type, double rate)
    {
        vehicleNumber = number;
        this.type = type;
        rentalRate = rate;
    }

    protected double GetRentalRate() => rentalRate;

    public abstract double CalculateRentalCost(int days);

    public void DisplayDetails(int days)
    {
        double rentalCost = CalculateRentalCost(days);
        double insuranceCost = this is IInsurable insurable ? insurable.CalculateInsurance() : 0;
        Console.WriteLine($"{vehicleNumber}\t{type}\t{days}\t{rentalCost}\t{insuranceCost}\t{rentalCost + insuranceCost}");
    }
}

class Car : Vehicle, IInsurable
{
    public Car(string number) : base(number, "Car", 1500) { }

    public override double CalculateRentalCost(int days) => GetRentalRate() * days;

    public double CalculateInsurance() => GetRentalRate() * 0.05;

    public string GetInsuranceDetails() => "5% Insurance Fee";
}

class Bike : Vehicle
{
    public Bike(string number) : base(number, "Bike", 500) { }

    public override double CalculateRentalCost(int days) => GetRentalRate() * days;
}

class Truck : Vehicle, IInsurable
{
    public Truck(string number) : base(number, "Truck", 3000) { }

    public override double CalculateRentalCost(int days) => GetRentalRate() * days;

    public double CalculateInsurance() => GetRentalRate() * 0.08;

    public string GetInsuranceDetails() => "8% Insurance Fee";
}

class Program
{
    static void Main()
    {
        var vehicles = new List<Vehicle>
        {
            new Car("CAR101"),
            new Bike("BIKE202"),
            new Truck("TRUCK303"),
            new Car("CAR404"),
            new Bike("BIKE505"),
            new Truck("TRUCK606")
        };

        int days = 5;
        Console.WriteLine("Number\tType\tDays\tRental\tInsurance\tTotal Cost");
        vehicles.ForEach(v => v.DisplayDetails(days));
    }
}
