using System;
using System.Globalization;

public class DateFormatter
{
    public string FormatDate(string inputDate)
    {
        if (DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
        {
            return date.ToString("dd-MM-yyyy");
        }
        else
        {
            throw new FormatException("invalid date format");
        }
    }
}





using NUnit.Framework;
using System;

[TestFixture]
public class DateFormatterTests
{
    private DateFormatter formatter;

    [SetUp]
    public void Setup()
    {
        formatter = new DateFormatter();
    }

    [Test]
    public void ValidDate_ShouldFormatCorrectly()
    {
        Assert.AreEqual("31-12-2023", formatter.FormatDate("2023-12-31"));
        Assert.AreEqual("01-01-2024", formatter.FormatDate("2024-01-01"));
        Assert.AreEqual("15-08-1947", formatter.FormatDate("1947-08-15"));
    }

    [Test]
    public void InvalidDateFormat_ShouldThrowFormatException()
    {
        Assert.Throws<FormatException>(() => formatter.FormatDate("12/31/2023"));
        Assert.Throws<FormatException>(() => formatter.FormatDate("31-12-2023"));
        Assert.Throws<FormatException>(() => formatter.FormatDate("2023.12.31"));
    }

    [Test]
    public void EmptyOrNullDate_ShouldThrowFormatException()
    {
        Assert.Throws<FormatException>(() => formatter.FormatDate(""));
        Assert.Throws<FormatException>(() => formatter.FormatDate(null));
    }
}
