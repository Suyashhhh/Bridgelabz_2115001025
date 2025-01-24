
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        double[,] marks = new double[numberOfStudents, 3];
        double[] percentages = new double[numberOfStudents];
        string[] grades = new string[numberOfStudents];

        for (int i = 0; i < numberOfStudents; i++)
        {
            double physics, chemistry, maths;
            do
            {
                Console.Write($"Enter the marks in Physics for student {i + 1}: ");
                physics = double.Parse(Console.ReadLine());
            } while (physics < 0);

            do
            {
                Console.Write($"Enter the marks in Chemistry for student {i + 1}: ");
                chemistry = double.Parse(Console.ReadLine());
            } while (chemistry < 0);

            do
            {
                Console.Write($"Enter the marks in Maths for student {i + 1}: ");
                maths = double.Parse(Console.ReadLine());
            } while (maths < 0);

            marks[i, 0] = physics;
            marks[i, 1] = chemistry;
            marks[i, 2] = maths;

            percentages[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3;

            if (percentages[i] >= 80)
                grades[i] = "Level 4";
            else if (percentages[i] >= 70)
                grades[i] = "Level 3";
            else if (percentages[i] >= 60)
                grades[i] = "Level 2";
            else if (percentages[i] >= 50)
                grades[i] = "Level 1";
            else if (percentages[i] >= 40)
                grades[i] = "Level 1-";
            else
                grades[i] = "Remedial Standards";
        }

        Console.WriteLine("\nStudent | Physics | Chemistry | Maths | Percentage | Grade");
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"{i + 1} | {marks[i, 0]:0.00} | {marks[i, 1]:0.00} | {marks[i, 2]:0.00} | {percentages[i]:0.00}% | {grades[i]}");
        }
    }
}

