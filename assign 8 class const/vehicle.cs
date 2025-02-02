using System;
class Vehicle
{
    public string ownerName;
    public string vehicleType;
    public static double registrationFee = 100;

    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"owner name: {ownerName}, vehicle type: {vehicleType}, registration fee: {registrationFee}");
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }

    static void Main()
    {
        Vehicle v1 = new Vehicle("alice", "sedan");
        v1.DisplayVehicleDetails();
        Vehicle.UpdateRegistrationFee(120);
    }
}
