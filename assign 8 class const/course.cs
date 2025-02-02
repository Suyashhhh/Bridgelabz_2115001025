
using System;
class Course
{
    public string courseName;
    public int duration;
    public double fee;
    public static string instituteName = "XYZ Institute";

    public Course(string courseName, int duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine($"course name: {courseName}, duration: {duration} months, fee: {fee}");
    }

    public static void UpdateInstituteName(string newInstituteName)
    {
        instituteName = newInstituteName;
    }

    static void Main()
    {
        Course c1 = new Course("c# programming", 3, 500);
        c1.DisplayCourseDetails();
        Course.UpdateInstituteName("ABC Academy");
    }
}

