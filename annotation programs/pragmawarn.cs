using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            #pragma warning disable CS0618  // Suppresses the warning for using non-generic collections

            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("hello");
            list.Add(3.14);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            #pragma warning restore CS0618  // Re-enables the warning
        }
        catch (Exception ex)
        {
            Console.WriteLine("an error occurred: " + ex.Message);
        }
    }
}
