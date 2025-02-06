using System;
using System.Collections.Generic;

class Company
{
    private string name;
    private List<Department> departments = new List<Department>();

    public Company(string name)
    {
        this.name = name;
    }

    public void AddDepartment(string deptName)
    {
        departments.Add(new Department(deptName));
    }

    public void AddEmployee(string deptName, string empName, string empID)
    {
        foreach (var dept in departments)
        {
            if (dept.GetName() == deptName)
            {
                dept.AddEmployee(empName, empID);
                return;
            }
        }
        Console.WriteLine("department not found: " + deptName);
    }

    public void ShowDetails()
    {
        Console.WriteLine("company: " + name);
        foreach (var dept in departments)
            dept.ShowEmployees();
    }
}

class Department
{
    private string name;
    private List<Employee> employees = new List<Employee>();

    public Department(string name)
    {
        this.name = name;
    }

    public void AddEmployee(string empName, string empID)
    {
        employees.Add(new Employee(empName, empID));
    }

    public void ShowEmployees()
    {
        Console.WriteLine("department: " + name);
        foreach (var emp in employees)
            Console.WriteLine("employee: " + emp.GetName() + "\tid: " + emp.GetID());
    }

    public string GetName() { return name; }
}

class Employee
{
    private string name;
    private string empID;

    public Employee(string name, string empID)
    {
        this.name = name;
        this.empID = empID;
    }

    public string GetName() { return name; }
    public string GetID() { return empID; }
}

class Program
{
    static void Main()
    {
        Company tcs = new Company("TCS");
        tcs.AddDepartment("IT");
        tcs.AddDepartment("HR");

        tcs.AddEmployee("IT", "Rajesh Kumar", "E101");
        tcs.AddEmployee("IT", "Priya Sharma", "E102");
        tcs.AddEmployee("HR", "Amit Verma", "E201");

        tcs.ShowDetails();
    }
}
