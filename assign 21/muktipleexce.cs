using System;

class ArrayHandler
{
    public void AccessArrayElement(int[] array, int index)
    {
        try
        {
            int value = array[index];
            Console.WriteLine("value at index " + index + ": " + value);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("index out of range");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("array is null");
        }
    }
}

class Program
{
    static void Main()
    {
        ArrayHandler handler = new ArrayHandler();
        try
        {
            Console.WriteLine("enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("enter element " + (i + 1) + ":");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("enter the index to retrieve:");
            int index = int.Parse(Console.ReadLine());

            handler.AccessArrayElement(numbers, index);
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid input, please enter numeric values");
        }
    }
}
