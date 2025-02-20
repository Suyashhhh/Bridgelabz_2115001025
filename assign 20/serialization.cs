using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class EmployeeSerialization
{
    static string filePath = "employees.json";

    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "ramesh", Department = "IT", Salary = 75000 },
            new Employee { Id = 2, Name = "suresh", Department = "HR", Salary = 55000 },
            new Employee { Id = 3, Name = "jagdish", Department = "Finance", Salary = 62000 }
        };

        try
        {
            SerializeEmployees(employees);
            Console.WriteLine("employees saved successfully.");
            
            List<Employee> retrievedEmployees = DeserializeEmployees();
            Console.WriteLine("retrieved employees:");
            foreach (var emp in retrievedEmployees)
            {
                Console.WriteLine(emp.Id + " " + emp.Name + " " + emp.Department + " " + emp.Salary);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("error: " + e.Message);
        }
    }

    static void SerializeEmployees(List<Employee> employees)
    {
        try
        {
            string jsonData = JsonSerializer.Serialize(employees);
            File.WriteAllText(filePath, jsonData);
        }
        catch (Exception e)
        {
            Console.WriteLine("serialization error: " + e.Message);
        }
    }

    static List<Employee> DeserializeEmployees()
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("no employee data found.");
                return new List<Employee>();
            }

            string jsonData = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Employee>>(jsonData) ?? new List<Employee>();
        }
        catch (Exception e)
        {
            Console.WriteLine("deserialization error: " + e.Message);
            return new List<Employee>();
        }
    }
}
