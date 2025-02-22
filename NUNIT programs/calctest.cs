public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        try
        {
            return a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("error: division by zero is not allowed");
            return 0;
        }
    }
}




using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void Add_ShouldReturnCorrectSum()
    {
        int result = calculator.Add(10, 5);
        Assert.AreEqual(15, result);
    }

    [Test]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        int result = calculator.Subtract(10, 5);
        Assert.AreEqual(5, result);
    }

    [Test]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        int result = calculator.Multiply(10, 5);
        Assert.AreEqual(50, result);
    }

    [Test]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        int result = calculator.Divide(10, 5);
        Assert.AreEqual(2, result);
    }

    [Test]
    public void Divide_ByZero_ShouldThrowDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
    }
}

