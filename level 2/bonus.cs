
using System;
class Program
{
    static void Main()
    {
        double[] salaries = new double[10], yearsOfService = new double[10], newSalaries = new double[10], bonuses = new double[10];
        double totalBonus = 0.0, totalOldSalary = 0.0, totalNewSalary = 0.0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter salary of employee {i + 1}: ");
            salaries[i] = double.Parse(Console.ReadLine());
            Console.Write($"Enter years of service of employee {i + 1}: ");
            yearsOfService[i] = double.Parse(Console.ReadLine());
            if (salaries[i] <= 0 || yearsOfService[i] < 0)
            {
                Console.WriteLine("Invalid input, please enter again.");
                i--;
                continue;
            }
        }

        for (int i = 0; i < 10; i++)
        {
            double bonusPercent = yearsOfService[i] >= 5 ? 0.05 : 0.02;
            bonuses[i] = salaries[i] * bonusPercent;
            newSalaries[i] = salaries[i] + bonuses[i];
            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }

        Console.WriteLine($"\nTotal Bonus Payout: {totalBonus}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary}");
        Console.WriteLine($"Total New Salary: {totalNewSalary}");
    }
}
