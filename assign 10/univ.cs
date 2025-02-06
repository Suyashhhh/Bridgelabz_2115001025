using System;
using System.Collections.Generic;

class Student
{
    private string name;
    private List<Course> courses;

    public Student(string name)
    {
        this.name = name;
        courses = new List<Course>();
    }

    public void EnrollCourse(Course course)
    {
        courses.Add(course);
        course.AddStudent(this);
    }

    public void DisplayCourses()
    {
        Console.WriteLine($"{name} is enrolled in:");
        foreach (var course in courses)
        {
            Console.WriteLine(course.GetCourseName());
        }
    }
}

class Professor
{
    private string name;
    private List<Course> courses;

    public Professor(string name)
    {
        this.name = name;
        courses = new List<Course>();
    }

    public void AssignProfessor(Course course)
    {
        courses.Add(course);
        course.AssignProfessor(this);
    }

    public void DisplayCourses()
    {
        Console.WriteLine($"{name} teaches:");
        foreach (var course in courses)
        {
            Console.WriteLine(course.GetCourseName());
        }
    }
}

class Course
{
    private string courseName;
    private Professor professor;
    private List<Student> students;

    public Course(string courseName)
    {
        this.courseName = courseName;
        students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void AssignProfessor(Professor professor)
    {
        this.professor = professor;
    }

    public string GetCourseName()
    {
        return courseName;
    }

    public void DisplayCourseInfo()
    {
        Console.WriteLine($"Course: {courseName}");
        Console.WriteLine($"Professor: {professor?.GetName() ?? "None"}");
        Console.WriteLine("Enrolled Students:");
        foreach (var student in students)
        {
            Console.WriteLine(student.GetName());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("yadav");
        Student student2 = new Student("patell");

        Professor professor1 = new Professor("guru");

        Course course1 = new Course("Math ");
        Course course2 = new Course("Physics");

        student1.EnrollCourse(course1);
        student2.EnrollCourse(course2);

        professor1.AssignProfessor(course1);
        professor1.AssignProfessor(course2);

        student1.DisplayCourses();
        student2.DisplayCourses();
        professor1.DisplayCourses();
        course1.DisplayCourseInfo();
        course2.DisplayCourseInfo();
    }
}
