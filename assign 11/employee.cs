using System;

class Employee
{
    private string name;
    private int id;
    private double salary;

    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine(name + " " + id + " " + salary);
    }
}

class Manager : Employee
{
    private int teamSize;

    public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary)
    {
        this.teamSize = teamSize;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("team size " + teamSize);
    }
}

class Developer : Employee
{
    private string programmingLanguage;

    public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
    {
        this.programmingLanguage = programmingLanguage;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("language " + programmingLanguage);
    }
}

class Intern : Employee
{
    private string internshipDuration;

    public Intern(string name, int id, double salary, string internshipDuration) : base(name, id, salary)
    {
        this.internshipDuration = internshipDuration;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("duration " + internshipDuration);
    }
}

class Program
{
    static void Main()
    {
        Manager m = new Manager("chintu", 101, 75000.50, 10);
        Developer d = new Developer("gullu", 102, 55000.75, "c#");
        Intern i = new Intern("tinku", 103, 15000.25, "6 months");

        m.DisplayDetails();
        d.DisplayDetails();
        i.DisplayDetails();
    }
}
