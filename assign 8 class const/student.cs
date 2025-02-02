using System;
class Student
{
    public int rollNumber;
    protected string name;
    private double CGPA;

    public void SetCGPA(double cgpa)
    {
        CGPA = cgpa;
    }

    public double CGPAValue // public property to get CGPA directly
    {
        get { return CGPA; }
    }
}

class PostgraduateStudent : Student
{
    public void DisplayName() 
    {
        Console.WriteLine($"name: {name}");
    }

    static void Main()
    {
        PostgraduateStudent pgStudent = new PostgraduateStudent();
        pgStudent.rollNumber = 2115001234;
        pgStudent.SetCGPA(6.5);
        pgStudent.DisplayName();
        Console.WriteLine($"CGPA: {pgStudent.CGPAValue}"); // using property to access CGPA
    }
}
