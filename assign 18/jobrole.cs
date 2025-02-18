using System;
using System.Collections.Generic;

public abstract class JobRole
{
    public string RoleName { get; }
    protected JobRole(string roleName)
    {
        RoleName = roleName;
    }
    public override string ToString() => RoleName;
}

public class SoftwareEngineer : JobRole
{
    public SoftwareEngineer() : base("software engineer") { }
}

public class DataScientist : JobRole
{
    public DataScientist() : base("data scientist") { }
}

public class Resume<T> where T : JobRole
{
    public string Name { get; }
    public string Skills { get; }
    public T Role { get; }

    public Resume(string name, string skills, T role)
    {
        Name = name;
        Skills = skills;
        Role = role;
    }

    public override string ToString() => $"{Name} ({Role}): {Skills}";
}

public class ResumeScreeningSystem
{
    public void ScreenResume<T>(Resume<T> resume) where T : JobRole
    {
        Console.WriteLine($"resume for {resume} has been screened successfully.");
    }
}

class Program
{
    static void Main()
    {
        var screeningSystem = new ResumeScreeningSystem();

        var softwareEngineerResume = new Resume<SoftwareEngineer>("babloo", "c#, .net, aws", new SoftwareEngineer());
        var dataScientistResume = new Resume<DataScientist>("chintu", "python, sql, machine learning", new DataScientist());

        screeningSystem.ScreenResume(softwareEngineerResume);
        screeningSystem.ScreenResume(dataScientistResume);
    }
}
