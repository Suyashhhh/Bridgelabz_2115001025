using System;

class LegacyAPI
{
    [Obsolete("OldFeature is deprecated, please use NewFeature instead.")]
    public void OldFeature()
    {
        Console.WriteLine("this is the old feature");
    }

    public void NewFeature()
    {
        Console.WriteLine("this is the new feature");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            LegacyAPI api = new LegacyAPI();
            api.OldFeature();  // This will show a warning
            api.NewFeature();  // No warning
        }
        catch (Exception ex)
        {
            Console.WriteLine("an error occurred: " + ex.Message);
        }
    }
}
