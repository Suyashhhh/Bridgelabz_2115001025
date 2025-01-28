using System;
public class BMICalculator {
    public double CalculateBMI(double weight, double heightInCm) {
        double heightInMeters = heightInCm / 100;  
        return weight / (heightInMeters * heightInMeters);
    }

    public string[] DetermineBMIStatus(double[] bmis) {
        string[] statuses = new string[10];
        for (int i = 0; i < 10; i++) {
            if (bmis[i] < 18.5) {
                statuses[i] = "Underweight";
            } else if (bmis[i] >= 18.5 && bmis[i] < 24.9) {
                statuses[i] = "Normal weight";
            } else if (bmis[i] >= 25 && bmis[i] < 29.9) {
                statuses[i] = "Overweight";
            } else {
                statuses[i] = "Obese";
            }
        }
        return statuses;
    }

    public static void Main() {
        BMICalculator calculator = new BMICalculator();
        double[,] data = new double[10, 3]; 
        double[] bmis = new double[10];

        for (int i = 0; i < 10; i++) {
            Console.WriteLine($"Enter weight (kg) for person {i+1}:");
            data[i, 0] = double.Parse(Console.ReadLine());
            Console.WriteLine($"Enter height (cm) for person {i+1}:");
            data[i, 1] = double.Parse(Console.ReadLine());

            bmis[i] = calculator.CalculateBMI(data[i, 0], data[i, 1]);
            data[i, 2] = bmis[i];
        }

        string[] statuses = calculator.DetermineBMIStatus(bmis);

        for (int i = 0; i < 10; i++) {
            Console.WriteLine($"Person {i+1}: Weight = {data[i, 0]} kg, Height = {data[i, 1]} cm, BMI = {data[i, 2]:F2}, Status = {statuses[i]}");
        }
    }
}

