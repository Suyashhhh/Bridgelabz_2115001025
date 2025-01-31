using System;
class Employee {
    string Name;
    int Id, Salary;
    
    public Employee(string name, int id, int salary) {//constructor 
        this.Name = name;
        this.Id = id;
        this.Salary = salary;
    }

    public void DisplayDetails() {//method
        Console.WriteLine("name is " + Name);
        Console.WriteLine("salary is " + Salary);
        Console.WriteLine("id is " + Id); 
    }

    static void Main() {
        Employee emp1 = new Employee("lallu ", 234,59999); // creating object of the methodd
		
		emp1.DisplayDetails(); // calling the method to display details
    }
}
