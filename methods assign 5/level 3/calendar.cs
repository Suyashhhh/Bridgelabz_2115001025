using System;

public class CalendarDisplay {
    
    public static string GetMonthName(int month) {
        string[] months = { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
        return months[month - 1];
    }

    public static int GetDaysInMonth(int month, int year) {
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (month == 2 && IsLeapYear(year)) {
            return 29;
        }
        return daysInMonth[month - 1];
    }

    public static bool IsLeapYear(int year) {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    public static int GetFirstDayOfMonth(int month, int year) {
        int y = year;
        int m = month;
        if (m < 3) {
            m += 12;
            y--;
        }
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (1 + x + 31 * m0 / 12) % 7;
        return d0;
    }

    public static void DisplayCalendar(int month, int year) {
        string monthName = GetMonthName(month);
        int daysInMonth = GetDaysInMonth(month, year);
        int firstDay = GetFirstDayOfMonth(month, year);
        Console.WriteLine($"         {monthName} {year}");
        Console.WriteLine("sun mon tue wed thu fri sat");
        for (int i = 0; i < firstDay; i++) {
            Console.Write("    ");
        }
        for (int day = 1; day <= daysInMonth; day++) {
            Console.Write($"{day,3} ");
            if ((firstDay + day) % 7 == 0) {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }

    public static void Main() {
        Console.Write("enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("enter the year: ");
        int year = int.Parse(Console.ReadLine());
        DisplayCalendar(month, year);
    }
}

