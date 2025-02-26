using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Rajesh", Age = 35, Department = "IT" },
            new Employee { Name = "Meena", Age = 28, Department = "HR" }
        };

        string json = JsonConvert.SerializeObject(employees, Formatting.Indented);
        Console.WriteLine(json);
    }
}
