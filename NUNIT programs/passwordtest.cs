using System;
using System.Text.RegularExpressions;

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        if (string.IsNullOrEmpty(password) || password.Length < 8)
        {
            return false;
        }

        bool hasUppercase = false;
        bool hasDigit = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c))
            {
                hasUppercase = true;
            }
            if (char.IsDigit(c))
            {
                hasDigit = true;
            }
        }

        return hasUppercase && hasDigit;
    }
}





using NUnit.Framework;

[TestFixture]
public class PasswordValidatorTests
{
    private PasswordValidator validator;

    [SetUp]
    public void Setup()
    {
        validator = new PasswordValidator();
    }

    [Test]
    public void ValidPassword_ShouldReturnTrue()
    {
        Assert.IsTrue(validator.IsValid("Secure123"));
        Assert.IsTrue(validator.IsValid("PassWord9"));
        Assert.IsTrue(validator.IsValid("ValidPass1"));
    }

    [Test]
    public void PasswordTooShort_ShouldReturnFalse()
    {
        Assert.IsFalse(validator.IsValid("S1a"));
        Assert.IsFalse(validator.IsValid("Ab7"));
    }

    [Test]
    public void PasswordWithoutUppercase_ShouldReturnFalse()
    {
        Assert.IsFalse(validator.IsValid("password123"));
        Assert.IsFalse(validator.IsValid("weakpass9"));
    }

    [Test]
    public void PasswordWithoutDigit_ShouldReturnFalse()
    {
        Assert.IsFalse(validator.IsValid("NoDigitsHere"));
        Assert.IsFalse(validator.IsValid("UppercaseOnly"));
    }

    [Test]
    public void EmptyOrNullPassword_ShouldReturnFalse()
    {
        Assert.IsFalse(validator.IsValid(""));
        Assert.IsFalse(validator.IsValid(null));
    }
}
