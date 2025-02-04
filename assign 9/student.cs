using System;
class Student{
	static string UniversityName;
	private string Name {get ; set ;}
	readonly int RollNumber;
	private string Grade {get ; set;}
	static int total;
	public Student(string name,int roll,string grade){
		this.Name=name;
		this.RollNumber=roll;
		this.Grade=grade;
		total++;
	}
	public static void DisplayTotalStudents(){
		Console.WriteLine("the number os students are: "+total);
	}
	public void DisplayDetails(){
		if(this is Student){
			Console.WriteLine("student name is "+Name);
			Console.WriteLine("student roll number is : "+RollNumber);
			Console.WriteLine("grade is : "+Grade);
		}
	}
}
class Program{
	static void Main(){
		Student stu1=new Student("Akanksha",21153135,"O");
		stu1.DisplayDetails();
		Student stu2=new Student("kalpana",21231332,"A");
		stu2.DisplayDetails();
		Student.DisplayTotalStudents();
	}
}