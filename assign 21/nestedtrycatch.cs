using System;

class NestedExceptionHandling
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("enter array elements separated by space:");
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            Console.WriteLine("enter index to access:");
            int index = int.Parse(Console.ReadLine());

            try
            {
                int element = numbers[index];
                Console.WriteLine("enter divisor:");
                int divisor = int.Parse(Console.ReadLine());

                try
                {
                    int result = element / divisor;
                    Console.WriteLine("division result: " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("invalid array index!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid input: please enter integers only");
        }
    }
}
