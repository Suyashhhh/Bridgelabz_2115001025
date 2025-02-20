using System;
using System.IO;

class StudentDataBinary
{
    static string filePath = "students.dat";

    static void Main()
    {
        try
        {
            StoreStudentData();
            RetrieveStudentData();
        }
        catch (Exception e)
        {
            Console.WriteLine("error: " + e.Message);
        }
    }

    static void StoreStudentData()
    {
        try
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                writer.Write(101);
                writer.Write("ramesh");
                writer.Write(3.8);

                writer.Write(102);
                writer.Write("suresh");
                writer.Write(3.5);

                writer.Write(103);
                writer.Write("jagdish");
                writer.Write(3.9);
            }
            Console.WriteLine("student data saved successfully.");
        }
        catch (IOException e)
        {
            Console.WriteLine("io error: " + e.Message);
        }
    }

    static void RetrieveStudentData()
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("no student data found.");
                return;
            }

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                Console.WriteLine("retrieved student data:");
                while (fileStream.Position < fileStream.Length)
                {
                    int roll = reader.ReadInt32();
                    string name = reader.ReadString();
                    double gpa = reader.ReadDouble();
                    Console.WriteLine(roll + " " + name + " " + gpa);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("io error: " + e.Message);
        }
    }
}
