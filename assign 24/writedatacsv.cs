using System;
using System.IO;
using System.Collections.Generic;

public class EmployeeDataWriter
{
    public void WriteEmployeeData(string filePath)
    {
        try
        {
            List<string> employeeRecords = new List<string>
            {
                "ID,Name,Department,Salary",
                "1,Rajnikanth,HR,45000",
                "2,Chintu,IT,60000",
                "3,Pappu,Finance,55000",
                "4,Bittu,Marketing,50000",
                "5,Golu,Sales,48000"
            };

            File.WriteAllLines(filePath, employeeRecords);
            Console.WriteLine("employee data written successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }
}
