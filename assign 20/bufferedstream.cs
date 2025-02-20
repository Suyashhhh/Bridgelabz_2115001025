using System;
using System.Diagnostics;
using System.IO;

class BufferedFileCopy
{
    static void Main()
    {
        string sourceFile = "largefile.bin";
        string destFileBuffered = "copy_buffered.bin";
        string destFileUnbuffered = "copy_unbuffered.bin";
        int bufferSize = 4096;

        try
        {
            Console.WriteLine("copying using unbuffered file stream...");
            long timeUnbuffered = CopyWithFileStream(sourceFile, destFileUnbuffered, bufferSize);
            Console.WriteLine("time taken (unbuffered): " + timeUnbuffered + " ms");

            Console.WriteLine("copying using buffered stream...");
            long timeBuffered = CopyWithBufferedStream(sourceFile, destFileBuffered, bufferSize);
            Console.WriteLine("time taken (buffered): " + timeBuffered + " ms");
        }
        catch (Exception e)
        {
            Console.WriteLine("error: " + e.Message);
        }
    }

    static long CopyWithFileStream(string source, string destination, int bufferSize)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        try
        {
            using (FileStream sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream destStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[bufferSize];
                int bytesRead;
                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destStream.Write(buffer, 0, bytesRead);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("error: " + e.Message);
        }
        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }

    static long CopyWithBufferedStream(string source, string destination, int bufferSize)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        try
        {
            using (FileStream sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream destStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedSource = new BufferedStream(sourceStream, bufferSize))
            using (BufferedStream bufferedDest = new BufferedStream(destStream, bufferSize))
            {
                byte[] buffer = new byte[bufferSize];
                int bytesRead;
                while ((bytesRead = bufferedSource.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bufferedDest.Write(buffer, 0, bytesRead);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("error: " + e.Message);
        }
        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }
}
