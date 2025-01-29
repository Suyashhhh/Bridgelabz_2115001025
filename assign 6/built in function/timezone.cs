. 
using System;
class Program
{
    static void Main()
    {
        DateTimeOffset currentTime = DateTimeOffset.Now;

        TimeZoneInfo gmt = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(currentTime, gmt);
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(currentTime, ist);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(currentTime, pst);

        Console.WriteLine("current time in gmt: " + gmtTime);
        Console.WriteLine("current time in ist: " + istTime);
        Console.WriteLine("current time in pst: " + pstTime);
    }
}

