using System;
using System.Data.SqlClient;
using System.IO;

class DatabaseToCSVExporter
{
    public void ExportEmployeesToCSV(string connectionString, string outputPath)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    writer.WriteLine("EmployeeID,Name,Department,Salary");
                    while (reader.Read())
                    {
                        string line = $"{reader["EmployeeID"]},{reader["Name"]},{reader["Department"]},{reader["Salary"]}";
                        writer.WriteLine(line);
                    }
                }
            }

            Console.WriteLine("csv report generated successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }

    static void Main()
    {
        var exporter = new DatabaseToCSVExporter();
        string connectionString = "Data Source=localhost;Initial Catalog=CompanyDB;Integrated Security=True";
        exporter.ExportEmployeesToCSV(connectionString, "employee_report.csv");
    }
}
