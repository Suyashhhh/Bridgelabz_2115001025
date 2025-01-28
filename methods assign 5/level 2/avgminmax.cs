using System;

public class RandomValues {
    public int[] Generate4DigitRandomArray(int size) {
        Random rand = new Random();
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++) {
            numbers[i] = rand.Next(1000, 10000);
        }
        return numbers;
    }

    public void FindAverageMinMax(int[] numbers, out double avg, out int min, out int max) {
        double sum = 0;
        min = numbers[0];
        max = numbers[0];
        for (int i = 0; i < numbers.Length; i++) {
            sum += numbers[i];
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }
        avg = sum / numbers.Length;
    }

    public static void Main() {
        RandomValues randomValues = new RandomValues();
        int[] numbers = randomValues.Generate4DigitRandomArray(5);
        randomValues.FindAverageMinMax(numbers, out double avg, out int min, out int max);

        Console.WriteLine($"Average: {avg}");
        Console.WriteLine($"Min: {min}");
        Console.WriteLine($"Max: {max}");
    }
} 

