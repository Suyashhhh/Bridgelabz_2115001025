public class TemperatureConverter
{
    public double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}




using NUnit.Framework;

[TestFixture]
public class TemperatureConverterTests
{
    private TemperatureConverter converter;

    [SetUp]
    public void Setup()
    {
        converter = new TemperatureConverter();
    }

    [Test]
    public void CelsiusToFahrenheit_ShouldConvertCorrectly()
    {
        Assert.AreEqual(32, converter.CelsiusToFahrenheit(0), 0.01);
        Assert.AreEqual(212, converter.CelsiusToFahrenheit(100), 0.01);
        Assert.AreEqual(98.6, converter.CelsiusToFahrenheit(37), 0.01);
    }

    [Test]
    public void FahrenheitToCelsius_ShouldConvertCorrectly()
    {
        Assert.AreEqual(0, converter.FahrenheitToCelsius(32), 0.01);
        Assert.AreEqual(100, converter.FahrenheitToCelsius(212), 0.01);
        Assert.AreEqual(37, converter.FahrenheitToCelsius(98.6), 0.01);
    }

    [Test]
    public void NegativeCelsiusToFahrenheit_ShouldConvertCorrectly()
    {
        Assert.AreEqual(-40, converter.CelsiusToFahrenheit(-40), 0.01);
    }

    [Test]
    public void NegativeFahrenheitToCelsius_ShouldConvertCorrectly()
    {
        Assert.AreEqual(-40, converter.FahrenheitToCelsius(-40), 0.01);
    }
}
