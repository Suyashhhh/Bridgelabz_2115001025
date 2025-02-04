using System;
class Employee{
	static string CompanyName;
	private string Name {get ; set ;}
	readonly int Id;
	private string Designation {get ; set ;}
	static int TotalEmployees=0;
	public Employee(string name,int id,string designation,string companyname){
		this.Name=name;
		this.Id=id;
		this.Designation=designation;
		CompanyName=companyname;
		TotalEmployees++;
	}
	public static void DisplayTotal(){
		Console.WriteLine("total number of employees are:"+TotalEmployees);
	}
	public void DisplayDetails(){
		if(this is Employee){
			Console.WriteLine("emplyee name"+Name);
			Console.WriteLine("emplyee ID"+Id);
			Console.WriteLine("emplyee designation"+Designation);
			Console.WriteLine("company name is "+CompanyName);
		}
	}
}
class Program{
	static void Main(){
		Employee emp1=new Employee("Suyash",1025,"senior pentester","Capgemini");
		emp1.DisplayDetails();
		Employee emp2=new Employee("lara",1011,"senior pentester","Capgemini");
		emp2.DisplayDetails();
		Employee.DisplayTotal();
		
	}
}