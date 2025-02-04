using System;
class Patient {
    static string HospitalName;
    static int TotalPatients = 0;
    readonly int PatientID;
    private string Name;
    private int Age;
    private string Ailment;

    public Patient(string name, int age, string ailment, int patientID) {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientID = patientID;
        TotalPatients++;  
    }

    public static void GetTotalPatients() {
        Console.WriteLine("Total patients admitted: " + TotalPatients);
    }

    public static void SetHospitalName(string hospitalName) {
        HospitalName = hospitalName;
    }

    public void DisplayDetails() {
        if (this is Patient) {
            Console.WriteLine("Hospital Name: " + HospitalName);
            Console.WriteLine("Patient Name: " + Name);
            Console.WriteLine("Patient Age: " + Age);
            Console.WriteLine("Ailment: " + Ailment);
            Console.WriteLine("Patient ID: " + PatientID);
        }
    }
}

class Program {
    static void Main() {
        Patient.SetHospitalName("City Hospital");

        Patient p1 = new Patient("John Doe", 30, "Fever", 1001);
        p1.DisplayDetails();

        Patient p2 = new Patient("Jane Smith", 45, "Cough", 1002);
        p2.DisplayDetails();

        Patient.GetTotalPatients(); 
    }
}