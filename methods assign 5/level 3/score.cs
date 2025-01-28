using System;

public class StudentScores {

    public static int[,] GenerateRandomScores(int numberOfStudents) {
        Random rand = new Random();
        int[,] scores = new int[numberOfStudents, 3];
        for (int i = 0; i < numberOfStudents; i++) {
            scores[i, 0] = rand.Next(50, 100);
            scores[i, 1] = rand.Next(50, 100);
            scores[i, 2] = rand.Next(50, 100);
        }
        return scores;
    }

    public static double[,] CalculateTotalsAveragesPercentages(int[,] scores, int numberOfStudents) {
        double[,] results = new double[numberOfStudents, 4];
        for (int i = 0; i < numberOfStudents; i++) {
            double total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = total / 3;
            double percentage = (total / 300) * 100;
            results[i, 0] = total;
            results[i, 1] = average;
            results[i, 2] = percentage;
            results[i, 3] = GetLevel(percentage);
        }
        return results;
    }

    public static int GetLevel(double percentage) {
        if (percentage >= 80) return 4;
        else if (percentage >= 70) return 3;
        else if (percentage >= 60) return 2;
        else if (percentage >= 50) return 1;
        else if (percentage >= 30) return 11;
        return 0;
    }

    public static void DisplayScorecard(double[,] results, int[,] scores, int numberOfStudents) {
        Console.WriteLine("Physics\tChemistry\tMaths\tTotal\tAverage\tPercentage\tLevel");
        for (int i = 0; i < numberOfStudents; i++) {
            Console.WriteLine($"{scores[i, 0]}\t{scores[i, 1]}\t{scores[i, 2]}\t{results[i, 0]}\t{Math.Round(results[i, 1], 2)}\t{Math.Round(results[i, 2], 2)}\t{results[i, 3]}");
        }
    }

    public static void Main() {
        int numberOfStudents = 5;
        int[,] scores = GenerateRandomScores(numberOfStudents);
        double[,] results = CalculateTotalsAveragesPercentages(scores, numberOfStudents);
        DisplayScorecard(results, scores, numberOfStudents);
    }
}



