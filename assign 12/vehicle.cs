using System;
using System.Collections.Generic;

interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

abstract class Vehicle : IGPS
{
    private int vehicleId;
    private string driverName;
    private double ratePerKm;
    private string currentLocation;

    protected Vehicle(int vehicleId, string driverName, double ratePerKm)
    {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
        currentLocation = "Unknown";
    }

    public abstract double CalculateFare(double distance);

    public string GetCurrentLocation() => currentLocation;

    public void UpdateLocation(string newLocation) => currentLocation = newLocation;

    protected double GetRate() => ratePerKm;

    public void GetVehicleDetails()
    {
        Console.WriteLine($"{vehicleId}\t{driverName}\t{ratePerKm}\t{currentLocation}");
    }
}

class Car : Vehicle
{
    public Car(int vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance) => distance * GetRate();
}

class Bike : Vehicle
{
    public Bike(int vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance) => distance * GetRate();
}

class Auto : Vehicle
{
    public Auto(int vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance) => distance * GetRate();
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car(101, "Chintu", 15),
            new Bike(102, "Pintu", 7),
            new Auto(103, "Bablu", 10)
        };

        vehicles[0].UpdateLocation("Market");
        vehicles[1].UpdateLocation("Mall");
        vehicles[2].UpdateLocation("Bus Stand");

        Console.WriteLine("ID\tDriver\tRate/km\tLocation");
        vehicles.ForEach(v => v.GetVehicleDetails());

        Console.WriteLine("\nFares for 10 km ride:");
        vehicles.ForEach(v => Console.WriteLine($"{v.CalculateFare(10)}"));
    }
}
