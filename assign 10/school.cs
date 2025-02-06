using System;
using System.Collections.Generic;

class School
{
    private string name;
    private List<Student> students = new List<Student>();

    public School(string name)
    {
        this.name = name;
    }

    public void AdmitStudent(Student student)
    {
        students.Add(student);
    }

    public void ShowStudents()
    {
        Console.WriteLine("school: " + name);
        foreach (var student in students)
            Console.WriteLine("student: " + student.GetName() + "\tid: " + student.GetID());
    }
}

class Student
{
    private string name;
    private string studentID;
    private List<Course> courses = new List<Course>();

    public Student(string name, string studentID)
    {
        this.name = name;
        this.studentID = studentID;
    }

    public void Enroll(Course course)
    {
        if (!courses.Contains(course))
        {
            courses.Add(course);
            course.AddStudent(this);
        }
    }

    public void ShowCourses()
    {
        Console.WriteLine("student: " + name);
        foreach (var course in courses)
            Console.WriteLine("enrolled in: " + course.GetName());
    }

    public string GetName() { return name; }
    public string GetID() { return studentID; }
}

class Course
{
    private string name;
    private List<Student> students = new List<Student>();

    public Course(string name)
    {
        this.name = name;
    }

    public void AddStudent(Student student)
    {
        if (!students.Contains(student))
            students.Add(student);
    }

    public void ShowStudents()
    {
        Console.WriteLine("course: " + name);
        foreach (var student in students)
            Console.WriteLine("student: " + student.GetName() + "\tid: " + student.GetID());
    }

    public string GetName() { return name; }
}

class Program
{
    static void Main()
    {
        School dps = new School("Delhi Public School");

        Student raj = new Student("Raj Mehta", "S101");
        Student anjali = new Student("Anjali Sharma", "S102");

        Course math = new Course("Mathematics");
        Course science = new Course("Science");

        dps.AdmitStudent(raj);
        dps.AdmitStudent(anjali);

        raj.Enroll(math);
        raj.Enroll(science);
        anjali.Enroll(math);

        Console.WriteLine();
        dps.ShowStudents();
        Console.WriteLine();
        raj.ShowCourses();
        Console.WriteLine();
        anjali.ShowCourses();
        Console.WriteLine();
        math.ShowStudents();
        Console.WriteLine();
        science.ShowStudents();
    }
}
