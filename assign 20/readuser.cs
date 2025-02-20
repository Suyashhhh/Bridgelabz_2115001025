using System;
using System.IO;

class UserInputToFile
{
    static void Main()
    {
        string filePath = "user_data.txt";

        try
        {
            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("enter your age:");
            string age = Console.ReadLine();

            Console.WriteLine("enter your favorite programming language:");
            string language = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("name: " + name);
                writer.WriteLine("age: " + age);
                writer.WriteLine("favorite language: " + language);
            }

            Console.WriteLine("data saved successfully in " + filePath);
        }
        catch (Exception e)
        {
            Console.WriteLine("error: " + e.Message);
        }
    }
}
