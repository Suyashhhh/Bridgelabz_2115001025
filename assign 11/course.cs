using System;
// Base class representing a Course
public class Course
{
public string CourseName { get; set; }
public int Duration { get; set; } // Duration in weeks
public Course(string courseName, int duration)
{
CourseName = courseName;
Duration = duration;
}
// Virtual method to be overridden in subclasses
public virtual void DisplayCourseInfo()
{
Console.WriteLine("Course: {0}, Duration: {1} weeks", CourseName,
Duration);
}
}
// Subclass OnlineCourse
public class OnlineCourse : Course
{
public string Platform { get; set; }
public bool IsRecorded { get; set; }
public OnlineCourse(string courseName, int duration, string platform,
bool isRecorded)
: base(courseName, duration)
{
Platform = platform;
IsRecorded = isRecorded;
}
public override void DisplayCourseInfo()
{
Console.WriteLine("Course: {0}, Duration: {1} weeks, Platform: {2},
Recorded: {3}", CourseName, Duration, Platform, IsRecorded ? "Yes" : "No");
}
}
// Subclass PaidOnlineCourse
public class PaidOnlineCourse : OnlineCourse
{
public double Fee { get; set; }
public double Discount { get; set; }
public PaidOnlineCourse(string courseName, int duration, string
platform, bool isRecorded, double fee, double discount)
: base(courseName, duration, platform, isRecorded)
{
Fee = fee;
Discount = discount;
}
public override void DisplayCourseInfo()
{
double finalPrice = Fee - (Fee * Discount / 100);
Console.WriteLine("Course: {0}, Duration: {1} weeks, Platform: {2},
Recorded: {3}, Fee: ${4}, Discount: {5}%, Final Price: ${6}",
CourseName, Duration, Platform, IsRecorded ? "Yes" : "No", Fee,
Discount, finalPrice);
}
}
// Main Program
public class Program
{
public static void Main()
{
Course course = new Course("Math Basics", 4);
course.DisplayCourseInfo();
OnlineCourse onlineCourse = new OnlineCourse("Python Programming",
6, "Udemy", true);
onlineCourse.DisplayCourseInfo();
PaidOnlineCourse paidCourse = new PaidOnlineCourse("Machine
Learning", 8, "Coursera", true, 200, 10);
paidCourse.DisplayCourseInfo();
}
}