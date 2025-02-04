using System;
class Vehicle{
	static int RegistrationFee;
	private string OwnerName {get ; set ;}
	private string VehicleType;
	readonly int RegistrationNumber;
	public Vehicle(string name,string type,int regnum){
		this.OwnerName=name;
		this.VehicleType=type;
		this.RegistrationNumber=regnum;
	}
	public static void UpdateRegistrationFee(int fee){
		RegistrationFee=fee;
	}
	public void DisplayDetails(){
		if(this is Vehicle){
			Console.WriteLine("Owner name is "+OwnerName);
			Console.WriteLine("vehicle type is : "+VehicleType);
			Console.WriteLine("registration number is  "+RegistrationNumber);
			Console.WriteLine("updated registration fee is : "+RegistrationFee);
		}
	}
}
class Program{
	static void Main(){
		Vehicle.UpdateRegistrationFee(1500);
		Vehicle veh1=new Vehicle("yogi","bulldozer",12321313);
		veh1.DisplayDetails();
		Vehicle.UpdateRegistrationFee(2000);
		Vehicle veh2=new Vehicle("gillu","tempo",345435435);
		veh2.DisplayDetails();
		
	}
}