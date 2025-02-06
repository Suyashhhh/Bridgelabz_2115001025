using System;
using System.Collections.Generic;

class University
{
    private string name;
    private List<Department> departments = new List<Department>();
    private List<Faculty> faculties = new List<Faculty>();

    public University(string name)
    {
        this.name = name;
    }

    public void AddDepartment(string deptName)
    {
        departments.Add(new Department(deptName));
    }

    public void AddFaculty(Faculty faculty)
    {
        faculties.Add(faculty);
    }

    public void AssignFacultyToDepartment(string deptName, Faculty faculty)
    {
        foreach (var dept in departments)
        {
            if (dept.GetName() == deptName)
            {
                dept.AddFaculty(faculty);
                return;
            }
        }
        Console.WriteLine("department not found: " + deptName);
    }

    public void ShowDetails()
    {
        Console.WriteLine("university: " + name);
        Console.WriteLine("\ndepartments:");
        foreach (var dept in departments)
            dept.ShowFaculty();
        Console.WriteLine("\nindependent faculty:");
        foreach (var fac in faculties)
            if (!fac.IsAssigned())
                Console.WriteLine("faculty: " + fac.GetName() + "\tid: " + fac.GetID());
    }
}

class Department
{
    private string name;
    private List<Faculty> faculties = new List<Faculty>();

    public Department(string name)
    {
        this.name = name;
    }

    public void AddFaculty(Faculty faculty)
    {
        faculties.Add(faculty);
        faculty.Assign();
    }

    public void ShowFaculty()
    {
        Console.WriteLine("department: " + name);
        foreach (var fac in faculties)
            Console.WriteLine("faculty: " + fac.GetName() + "\tid: " + fac.GetID());
    }

    public string GetName() { return name; }
}

class Faculty
{
    private string name;
    private string facultyID;
    private bool assigned = false;

    public Faculty(string name, string facultyID)
    {
        this.name = name;
        this.facultyID = facultyID;
    }

    public void Assign() { assigned = true; }
    public bool IsAssigned() { return assigned; }

    public string GetName() { return name; }
    public string GetID() { return facultyID; }
}

class Program
{
    static void Main()
    {
        University iitDelhi = new University("IIT Delhi");

        iitDelhi.AddDepartment("Computer Science");
        iitDelhi.AddDepartment("Electrical Engineering");

        Faculty drSharma = new Faculty("Dr. Rakesh Sharma", "F101");
        Faculty profVerma = new Faculty("Prof. Alok Verma", "F102");
        Faculty drKaur = new Faculty("Dr. Simran Kaur", "F103");

        iitDelhi.AddFaculty(drSharma);
        iitDelhi.AddFaculty(profVerma);
        iitDelhi.AddFaculty(drKaur);

        iitDelhi.AssignFacultyToDepartment("Computer Science", drSharma);
        iitDelhi.AssignFacultyToDepartment("Electrical Engineering", profVerma);

        iitDelhi.ShowDetails();
    }
}
