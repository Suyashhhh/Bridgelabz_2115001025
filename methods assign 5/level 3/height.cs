using System;

public class FootballTeam {
    public int FindSum(int[] heights) {
        int sum = 0;
        for (int i = 0; i < heights.Length; i++) {
            sum += heights[i];
        }
        return sum;
    }

    public double FindMean(int sum, int size) {
        return (double)sum / size;
    }

    public int FindShortest(int[] heights) {
        int shortest = heights[0];
        for (int i = 1; i < heights.Length; i++) {
            shortest = Math.Min(shortest, heights[i]);
        }
        return shortest;
    }

    public int FindTallest(int[] heights) {
        int tallest = heights[0];
        for (int i = 1; i < heights.Length; i++) {
            tallest = Math.Max(tallest, heights[i]);
        }
        return tallest;
    }

    public static void Main() {
        Random rand = new Random();
        int[] heights = new int[11];
        for (int i = 0; i < 11; i++) {
            heights[i] = rand.Next(150, 251);
        }

        FootballTeam team = new FootballTeam();
        int sum = team.FindSum(heights);
        double mean = team.FindMean(sum, heights.Length);
        int shortest = team.FindShortest(heights);
        int tallest = team.FindTallest(heights);

        Console.WriteLine($"Shortest height: {shortest} cm");
        Console.WriteLine($"Tallest height: {tallest} cm");
        Console.WriteLine($"Mean height: {mean:F2} cm");
    }
}

