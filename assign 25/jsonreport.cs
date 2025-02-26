using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        string connectionString = "your_connection_string_here";
        string query = "SELECT Name, Age, Department FROM Employees";

        List<Employee> employees = new List<Employee>();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new Employee
                        {
                            Name = reader.GetString(0),
                            Age = reader.GetInt32(1),
                            Department = reader.GetString(2)
                        });
                    }
                }
            }
        }

        string json = JsonConvert.SerializeObject(employees, Formatting.Indented);
        Console.WriteLine(json);
    }
}
