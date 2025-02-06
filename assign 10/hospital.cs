using System;
using System.Collections.Generic;

class Hospital
{
    private string name;
    private List<Doctor> doctors = new List<Doctor>();
    private List<Patient> patients = new List<Patient>();

    public Hospital(string name)
    {
        this.name = name;
    }

    public void AddDoctor(Doctor doctor)
    {
        doctors.Add(doctor);
    }

    public void AddPatient(Patient patient)
    {
        patients.Add(patient);
    }

    public void ShowDetails()
    {
        Console.WriteLine("hospital: " + name);
        Console.WriteLine("\ndoctors:");
        foreach (var doc in doctors)
            Console.WriteLine("doctor: " + doc.GetName() + "\tid: " + doc.GetID());
        Console.WriteLine("\npatients:");
        foreach (var pat in patients)
            Console.WriteLine("patient: " + pat.GetName() + "\tid: " + pat.GetID());
    }
}

class Doctor
{
    private string name;
    private string doctorID;
    private List<Patient> patients = new List<Patient>();

    public Doctor(string name, string doctorID)
    {
        this.name = name;
        this.doctorID = doctorID;
    }

    public void Consult(Patient patient)
    {
        if (!patients.Contains(patient))
        {
            patients.Add(patient);
            patient.AddDoctor(this);
        }
        Console.WriteLine("consultation: " + name + " is seeing " + patient.GetName());
    }

    public void ShowPatients()
    {
        Console.WriteLine("doctor: " + name);
        foreach (var pat in patients)
            Console.WriteLine("patient: " + pat.GetName() + "\tid: " + pat.GetID());
    }

    public string GetName() { return name; }
    public string GetID() { return doctorID; }
}

class Patient
{
    private string name;
    private string patientID;
    private List<Doctor> doctors = new List<Doctor>();

    public Patient(string name, string patientID)
    {
        this.name = name;
        this.patientID = patientID;
    }

    public void AddDoctor(Doctor doctor)
    {
        if (!doctors.Contains(doctor))
            doctors.Add(doctor);
    }

    public void ShowDoctors()
    {
        Console.WriteLine("patient: " + name);
        foreach (var doc in doctors)
            Console.WriteLine("doctor: " + doc.GetName() + "\tid: " + doc.GetID());
    }

    public string GetName() { return name; }
    public string GetID() { return patientID; }
}

class Program
{
    static void Main()
    {
        Hospital aiims = new Hospital("AIIMS Delhi");

        Doctor chintu = new Doctor("Chintu", "D101");
        Doctor pintu = new Doctor("Pintu", "D102");

        Patient bunty = new Patient("Bunty", "P201");
        Patient babloo = new Patient("Babloo", "P202");
        Patient munni = new Patient("Munni", "P203");

        aiims.AddDoctor(chintu);
        aiims.AddDoctor(pintu);

        aiims.AddPatient(bunty);
        aiims.AddPatient(babloo);
        aiims.AddPatient(munni);

        chintu.Consult(bunty);
        chintu.Consult(babloo);
        pintu.Consult(munni);
        pintu.Consult(bunty);

        Console.WriteLine();
        aiims.ShowDetails();
        Console.WriteLine();
        chintu.ShowPatients();
        Console.WriteLine();
        pintu.ShowPatients();
        Console.WriteLine();
        bunty.ShowDoctors();
        Console.WriteLine();
        babloo.ShowDoctors();
        Console.WriteLine();
        munni.ShowDoctors();
    }
}
