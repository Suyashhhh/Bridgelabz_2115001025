using System;

public class FriendComparison {
    public static void Main() {
        int[] ages = new int[3];
        int[] heights = new int[3];

        for (int i = 0; i < 3; i++) {
            ages[i] = int.Parse(Console.ReadLine());
            heights[i] = int.Parse(Console.ReadLine());
        }

        string FindYoungest(int[] ages) {
            int minAge = ages[0];
            string youngest = "Amar";
            if (ages[1] < minAge) {
                minAge = ages[1];
                youngest = "Akbar";
            }
            if (ages[2] < minAge) {
                youngest = "Anthony";
            }
            return youngest;
        }

        string FindTallest(int[] heights) {
            int maxHeight = heights[0];
            string tallest = "Amar";
            if (heights[1] > maxHeight) {
                maxHeight = heights[1];
                tallest = "Akbar";
            }
            if (heights[2] > maxHeight) {
                tallest = "Anthony";
            }
            return tallest;
        }

        Console.WriteLine(FindYoungest(ages) + " is the youngest.");
        Console.WriteLine(FindTallest(heights) + " is the tallest.");
    }
}

