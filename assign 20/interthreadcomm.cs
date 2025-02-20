using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;

class PipedStreamExample
{
    static void Main()
    {
        using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
        using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.GetClientHandleAsString()))
        {
            Thread writerThread = new Thread(() => WriteToPipe(pipeServer));
            Thread readerThread = new Thread(() => ReadFromPipe(pipeClient));

            writerThread.Start();
            readerThread.Start();

            writerThread.Join();
            readerThread.Join();
        }
    }

    static void WriteToPipe(PipeStream pipe)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(pipe, Encoding.UTF8) { AutoFlush = true })
            {
                for (int i = 1; i <= 5; i++)
                {
                    string message = "message " + i;
                    writer.WriteLine(message);
                    Console.WriteLine("written: " + message);
                    Thread.Sleep(500);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("write error: " + e.Message);
        }
    }

    static void ReadFromPipe(PipeStream pipe)
    {
        try
        {
            using (StreamReader reader = new StreamReader(pipe, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine("read: " + line);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("read error: " + e.Message);
        }
    }
}
