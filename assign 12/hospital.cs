using System;
using System.Collections.Generic;

interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

abstract class Patient : IMedicalRecord
{
    private int patientId;
    private string name;
    private int age;
    private List<string> medicalRecords;

    protected Patient(int patientId, string name, int age)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
        medicalRecords = new List<string>();
    }

    public abstract double CalculateBill();

    public void AddRecord(string record) => medicalRecords.Add(record);

    public void ViewRecords()
    {
        Console.Write($"{name} medical history: ");
        Console.WriteLine(medicalRecords.Count > 0 ? string.Join(", ", medicalRecords) : "No records");
    }

    public void GetPatientDetails()
    {
        Console.WriteLine($"{patientId}\t{name}\t{age}\t{CalculateBill()}");
    }
}

class InPatient : Patient
{
    private int daysAdmitted;
    private double dailyCharge;

    public InPatient(int patientId, string name, int age, int daysAdmitted, double dailyCharge)
        : base(patientId, name, age)
    {
        this.daysAdmitted = daysAdmitted;
        this.dailyCharge = dailyCharge;
    }

    public override double CalculateBill() => daysAdmitted * dailyCharge;
}

class OutPatient : Patient
{
    private double consultationFee;

    public OutPatient(int patientId, string name, int age, double consultationFee)
        : base(patientId, name, age)
    {
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill() => consultationFee;
}

class Program
{
    static void Main()
    {
        List<Patient> patients = new List<Patient>
        {
            new InPatient(101, "Chintu", 45, 5, 2000),
            new OutPatient(102, "Pintu", 30, 500)
        };

        patients[0].AddRecord("Diabetes");
        patients[1].AddRecord("Mild Fever");

        Console.WriteLine("ID\tName\tAge\tBill");
        patients.ForEach(p => p.GetPatientDetails());

        patients.ForEach(p => p.ViewRecords());
    }
}
