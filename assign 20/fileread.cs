using System;
using System.IO;

class FileReadWrite
{
    static void Main()
    {
        string sourceFile = "source.txt";
        string destinationFile = "destination.txt";

        try
        {
            using (FileStream sourceStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;
                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destinationStream.Write(buffer, 0, bytesRead);
                }
            }
            Console.WriteLine("file copied successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine("error: " + e.Message);
        }
    }
}

