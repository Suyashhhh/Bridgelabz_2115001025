using System;
// Base class representing a smart home device
public class Device
{
public int DeviceId { get; set; }
public string Status { get; set; }
public Device(int deviceId, string status)
{
DeviceId = deviceId;
Status = status;
}
// Virtual method to be overridden by subclasses
public virtual void DisplayStatus()
{
Console.WriteLine("Device ID: {0}, Status: {1}", DeviceId, Status);
}
}
// Subclass Thermostat
public class Thermostat : Device
{
public int TemperatureSetting { get; set; }
public Thermostat(int deviceId, string status, int temperatureSetting)
: base(deviceId, status)
{
TemperatureSetting = temperatureSetting;
}
public override void DisplayStatus()
{
Console.WriteLine("Device ID: {0}, Status: {1}, Temperature
Setting: {2}°C", DeviceId, Status, TemperatureSetting);
}
}
// Main Program
public class Program
{
public static void Main()
{
Thermostat thermostat = new Thermostat(101, "On", 22);
thermostat.DisplayStatus();
}
}
