using System;

public class ZaraBonus {

    public static double[,] GenerateEmployeeData(int size) {
        Random rand = new Random();
        double[,] employeeData = new double[size, 2];
        for (int i = 0; i < size; i++) {
            employeeData[i, 0] = rand.Next(10000, 99999);
            employeeData[i, 1] = rand.Next(1, 21);
        }
        return employeeData;
    }

    public static double[,] CalculateBonusAndSalary(double[,] employeeData, int size) {
        double[,] newData = new double[size, 3];
        for (int i = 0; i < size; i++) {
            double salary = employeeData[i, 0];
            double yearsOfService = employeeData[i, 1];
            double bonusPercentage = yearsOfService >= 5 ? 0.05 : 0.02;
            double bonus = salary * bonusPercentage;
            double newSalary = salary + bonus;
            newData[i, 0] = salary;
            newData[i, 1] = bonus;
            newData[i, 2] = newSalary;
        }
        return newData;
    }

    public static void CalculateTotals(double[,] newData, int size) {
        double oldSalaryTotal = 0, newSalaryTotal = 0, bonusTotal = 0;
        for (int i = 0; i < size; i++) {
            oldSalaryTotal += newData[i, 0];
            bonusTotal += newData[i, 1];
            newSalaryTotal += newData[i, 2];
        }
        Console.WriteLine("old salary\tbonus\tnew salary");
        for (int i = 0; i < size; i++) {
            Console.WriteLine($"{newData[i, 0],-12}\t{newData[i, 1],-6}\t{newData[i, 2],-10}");
        }
        Console.WriteLine($"\ntotal old salary: {oldSalaryTotal}");
        Console.WriteLine($"total bonus: {bonusTotal}");
        Console.WriteLine($"total new salary: {newSalaryTotal}");
    }

    public static void Main() {
        int numberOfEmployees = 10;
        double[,] employeeData = GenerateEmployeeData(numberOfEmployees);
        double[,] newData = CalculateBonusAndSalary(employeeData, numberOfEmployees);
        CalculateTotals(newData, numberOfEmployees);
    }
}

