using System;
using System.Collections.Generic;

public abstract class CourseType
{
    public string EvaluationMethod { get; }
    protected CourseType(string method) { EvaluationMethod = method; }
    public override string ToString() => EvaluationMethod;
}

public class ExamCourse : CourseType
{
    public ExamCourse() : base("exam based") { }
}

public class AssignmentCourse : CourseType
{
    public AssignmentCourse() : base("assignment based") { }
}

public class Course<T> where T : CourseType
{
    public string Name { get; }
    public int Credits { get; }
    public T Type { get; }

    public Course(string name, int credits, T type)
    {
        Name = name;
        Credits = credits;
        Type = type;
    }

    public override string ToString() => $"{Name} ({Credits} credits) - {Type}";
}

public class Department
{
    private readonly List<object> courses = new List<object>();

    public void AddCourse<T>(Course<T> course) where T : CourseType => courses.Add(course);
    public void DisplayCourses() => courses.ForEach(course => Console.Write(course + " "));
}

class Program
{
    static void Main()
    {
        var csDepartment = new Department();
        var mathDepartment = new Department();

        var algorithms = new Course<ExamCourse>("algorithms", 4, new ExamCourse());
        var calculus = new Course<ExamCourse>("calculus", 3, new ExamCourse());
        var softwareEngineering = new Course<AssignmentCourse>("software engineering", 3, new AssignmentCourse());

        csDepartment.AddCourse(algorithms);
        csDepartment.AddCourse(softwareEngineering);
        mathDepartment.AddCourse(calculus);

        Console.Write("cs department: "); csDepartment.DisplayCourses();
        Console.Write("math department: "); mathDepartment.DisplayCourses();
    }
}
