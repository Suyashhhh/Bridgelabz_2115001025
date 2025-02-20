using System;
using System.IO;
using System.Text;

class UpperToLowerConverter
{
    static void Main()
    {
        string sourceFile = "source.txt";
        string destinationFile = "converted.txt";

        try
        {
            ConvertUpperToLower(sourceFile, destinationFile);
            Console.WriteLine("file converted successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine("error: " + e.Message);
        }
    }

    static void ConvertUpperToLower(string source, string destination)
    {
        try
        {
            using (FileStream sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (BufferedStream bufferedStream = new BufferedStream(sourceStream))
            using (StreamReader reader = new StreamReader(bufferedStream, Encoding.UTF8))
            using (FileStream destinationStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(destinationStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("io error: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("error: " + e.Message);
        }
    }
}
