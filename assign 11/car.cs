using System;
// Base class representing a Vehicle
public class Vehicle
{
public int MaxSpeed { get; set; }
public string FuelType { get; set; }
public Vehicle(int maxSpeed, string fuelType)
{
MaxSpeed = maxSpeed;
FuelType = fuelType;
}
// Virtual method to be overridden by subclasses
public virtual void DisplayInfo()
{
Console.WriteLine("Max Speed: {0} km/h, Fuel Type: {1}", MaxSpeed,
FuelType);
}
}
// Subclass Car
public class Car : Vehicle
{
public int SeatCapacity { get; set; }
public Car(int maxSpeed, string fuelType, int seatCapacity) :
base(maxSpeed, fuelType)
{
SeatCapacity = seatCapacity;
}
public override void DisplayInfo()
{
Console.WriteLine("Max Speed: {0} km/h, Fuel Type: {1}, Seat
Capacity: {2}", MaxSpeed, FuelType, SeatCapacity);
}
}
// Subclass Truck
public class Truck : Vehicle
{
public int PayloadCapacity { get; set; }
public Truck(int maxSpeed, string fuelType, int payloadCapacity) :
base(maxSpeed, fuelType)
{
PayloadCapacity = payloadCapacity;
}
public override void DisplayInfo()
{
Console.WriteLine("Max Speed: {0} km/h, Fuel Type: {1}, Payload
Capacity: {2} kg", MaxSpeed, FuelType, PayloadCapacity);
}
}
// Subclass Motorcycle
public class Motorcycle : Vehicle
{
public bool HasSidecar { get; set; }
public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar) :
base(maxSpeed, fuelType)
{
HasSidecar = hasSidecar;
}
public override void DisplayInfo()
{
Console.WriteLine("Max Speed: {0} km/h, Fuel Type: {1}, Has
Sidecar: {2}", MaxSpeed, FuelType, HasSidecar);
}
}
// Main Program
public class Program
{
public static void Main()
{
Vehicle[] vehicles = new Vehicle[]
{
new Car(200, "Petrol", 5),
new Truck(120, "Diesel", 10000),
new Motorcycle(180, "Petrol", true)
};
foreach (Vehicle vehicle in vehicles)
{
vehicle.DisplayInfo();
