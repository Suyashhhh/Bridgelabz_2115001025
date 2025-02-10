using System;
using System.Collections.Generic;

interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

abstract class Employee : IDepartment
{
    private int employeeId;
    private string name;
    private string department;
    private double baseSalary;

    protected Employee(int id, string name, double salary)
    {
        employeeId = id;
        this.name = name;
        baseSalary = salary;
    }

    protected double GetBaseSalary() => baseSalary;

    public abstract double CalculateSalary();

    public void AssignDepartment(string dept) => department = dept;

    public string GetDepartmentDetails() => department;

    public void DisplayDetails() => Console.WriteLine($"{employeeId}\t{name}\t{CalculateSalary()}\t{department}");
}

class FullTimeEmployee : Employee
{
    private double bonus;

    public FullTimeEmployee(int id, string name, double salary, double bonus) : base(id, name, salary) => this.bonus = bonus;

    public override double CalculateSalary() => GetBaseSalary() + bonus;
}

class PartTimeEmployee : Employee
{
    private int hours;
    private double rate;

    public PartTimeEmployee(int id, string name, double rate, int hours) : base(id, name, 0)
    {
        this.rate = rate;
        this.hours = hours;
    }

    public override double CalculateSalary() => hours * rate;
}

class Program
{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new FullTimeEmployee(101, "Chintu", 50000, 5000),
            new PartTimeEmployee(102, "Pintu", 200, 80),
            new FullTimeEmployee(103, "Bablu", 60000, 7000),
            new PartTimeEmployee(104, "Lallu", 250, 60)
        };

        employees[0].AssignDepartment("HR");
        employees[1].AssignDepartment("IT");
        employees[2].AssignDepartment("Finance");
        employees[3].AssignDepartment("Marketing");

        Console.WriteLine("ID\tName\tSalary\tDepartment");
        employees.ForEach(e => e.DisplayDetails());
    }
}
