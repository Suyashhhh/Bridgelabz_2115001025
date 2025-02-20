using System;
using System.IO;

class ImageByteArray
{
    static void Main()
    {
        string sourceImage = "image.jpg";
        string destinationImage = "copy_image.jpg";

        try
        {
            byte[] imageData = ConvertImageToByteArray(sourceImage);
            File.WriteAllBytes(destinationImage, imageData);
            Console.WriteLine("image copied successfully.");
            
            bool isIdentical = CompareFiles(sourceImage, destinationImage);
            Console.WriteLine("verification: " + (isIdentical ? "files are identical" : "files are different"));
        }
        catch (Exception e)
        {
            Console.WriteLine("error: " + e.Message);
        }
    }

    static byte[] ConvertImageToByteArray(string imagePath)
    {
        try
        {
            using (FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            using (MemoryStream memoryStream = new MemoryStream())
            {
                fileStream.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("io error: " + e.Message);
            return new byte[0];
        }
    }

    static bool CompareFiles(string file1, string file2)
    {
        try
        {
            byte[] file1Bytes = File.ReadAllBytes(file1);
            byte[] file2Bytes = File.ReadAllBytes(file2);
            return file1Bytes.Length == file2Bytes.Length && StructuralComparisons.StructuralEqualityComparer.Equals(file1Bytes, file2Bytes);
        }
        catch (Exception e)
        {
            Console.WriteLine("comparison error: " + e.Message);
            return false;
        }
    }
}
