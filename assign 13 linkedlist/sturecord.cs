
using System;
class StudentNode
{
    public int RollNumber;
    public string Name;
    public int Age;
    public string Grade;
    public StudentNode Next;

    public StudentNode(int rollNumber, string name, int age, string grade)
    {
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentLinkedList
{
    private StudentNode head;

    public void AddStudentAtBeginning(int rollNumber, string name, int age, string grade)
    {
        StudentNode newStudent = new StudentNode(rollNumber, name, age, grade);
        newStudent.Next = head;
        head = newStudent;
    }

    public void AddStudentAtEnd(int rollNumber, string name, int age, string grade)
    {
        StudentNode newStudent = new StudentNode(rollNumber, name, age, grade);
        if (head == null)
        {
            head = newStudent;
            return;
        }
        StudentNode current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newStudent;
    }

    public void AddStudentAtPosition(int rollNumber, string name, int age, string grade, int position)
    {
        StudentNode newStudent = new StudentNode(rollNumber, name, age, grade);
        if (position == 1)
        {
            newStudent.Next = head;
            head = newStudent;
            return;
        }
        StudentNode current = head;
        for (int i = 1; i < position - 1 && current != null; i++)
        {
            current = current.Next;
        }
        if (current == null)
        {
            Console.WriteLine("Position out of range.");
            return;
        }
        newStudent.Next = current.Next;
        current.Next = newStudent;
    }

    public void DeleteStudent(int rollNumber)
    {
        if (head == null) return;
        if (head.RollNumber == rollNumber)
        {
            head = head.Next;
            return;
        }
        StudentNode current = head;
        while (current.Next != null && current.Next.RollNumber != rollNumber)
        {
            current = current.Next;
        }
        if (current.Next == null) return;
        current.Next = current.Next.Next;
    }

    public StudentNode SearchStudent(int rollNumber)
    {
        StudentNode current = head;
        while (current != null)
        {
            if (current.RollNumber == rollNumber) return current;
            current = current.Next;
        }
        return null;
    }

    public void UpdateStudentGrade(int rollNumber, string newGrade)
    {
        StudentNode student = SearchStudent(rollNumber);
        if (student != null) student.Grade = newGrade;
    }

    public void DisplayStudents()
    {
        StudentNode current = head;
        while (current != null)
        {
            Console.WriteLine($"{current.RollNumber}\t{current.Name}\t{current.Age}\t{current.Grade}");
            current = current.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        StudentLinkedList students = new StudentLinkedList();

        students.AddStudentAtEnd(101, "Raj", 18, "A");
        students.AddStudentAtEnd(102, "Amit", 19, "B");
        students.AddStudentAtBeginning(103, "Pooja", 18, "A+");
        students.AddStudentAtPosition(104, "Suresh", 20, "B+", 2);

        Console.WriteLine("Student Records:");
        students.DisplayStudents();
        Console.WriteLine();

        Console.WriteLine("Deleting Roll Number 102...");
        students.DeleteStudent(102);

        Console.WriteLine("Updating Grade for Roll Number 101...");
        students.UpdateStudentGrade(101, "A+");

        Console.WriteLine("Updated Student Records:");
        students.DisplayStudents();
    }
}

