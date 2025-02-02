using System;
class Employee
{
    public int employeeID;
    protected string department;
    private double salary;

    public void SetSalary(double salaryAmount)
    {
        salary = salaryAmount;
    }

    public double SalaryAmount // public property to get salary directly
    {
        get { return salary; }
    }
}

class Manager : Employee
{
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee ID: {employeeID}, Department: {department}");
    }

    static void Main()
    {
        Manager manager = new Manager();
        manager.employeeID = 125765;
        manager.SetSalary(84550);
        manager.DisplayEmployeeDetails();
        Console.WriteLine($"Salary: {manager.SalaryAmount}"); // using property to access salary
    }
}

