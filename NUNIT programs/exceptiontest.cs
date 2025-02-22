using System;

public class MathOperations
{
    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new ArithmeticException("division by zero is not allowed");
        }
        return a / b;
    }
}




using NUnit.Framework;

[TestFixture]
public class MathOperationsTests
{
    private MathOperations mathOperations;

    [SetUp]
    public void Setup()
    {
        mathOperations = new MathOperations();
    }

    [Test]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        int result = mathOperations.Divide(10, 2);
        Assert.AreEqual(5, result);
    }

    [Test]
    public void Divide_ByZero_ShouldThrowArithmeticException()
    {
        Assert.Throws<ArithmeticException>(() => mathOperations.Divide(10, 0));
    }
}
