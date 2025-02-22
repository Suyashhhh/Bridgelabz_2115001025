using System;
using System.Text.RegularExpressions;

public class UserRegistration
{
    public bool RegisterUser(string username, string email, string password)
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            throw new ArgumentException("username cannot be empty");
        }

        if (!IsValidEmail(email))
        {
            throw new ArgumentException("invalid email format");
        }

        if (!IsValidPassword(password))
        {
            throw new ArgumentException("password must be at least 8 characters long, contain one uppercase letter and one digit");
        }

        return true;
    }

    private bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }

    private bool IsValidPassword(string password)
    {
        if (password.Length < 8) return false;

        bool hasUpper = false, hasDigit = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c)) hasUpper = true;
            if (char.IsDigit(c)) hasDigit = true;
        }

        return hasUpper && hasDigit;
    }
}






using NUnit.Framework;
using System;

[TestFixture]
public class UserRegistrationTests
{
    private UserRegistration registration;

    [SetUp]
    public void Setup()
    {
        registration = new UserRegistration();
    }

    [Test]
    public void ValidUserRegistration_ShouldSucceed()
    {
        Assert.IsTrue(registration.RegisterUser("funnyraj", "raj@example.com", "Password1"));
        Assert.IsTrue(registration.RegisterUser("coolman", "cool@example.co", "CoolPass9"));
    }

    [Test]
    public void EmptyUsername_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => registration.RegisterUser("", "test@example.com", "Valid123"));
        Assert.Throws<ArgumentException>(() => registration.RegisterUser(null, "test@example.com", "Valid123"));
    }

    [Test]
    public void InvalidEmail_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => registration.RegisterUser("username", "invalid-email", "Valid123"));
        Assert.Throws<ArgumentException>(() => registration.RegisterUser("username", "email@.com", "Valid123"));
    }

    [Test]
    public void WeakPassword_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => registration.RegisterUser("username", "test@example.com", "weak"));
        Assert.Throws<ArgumentException>(() => registration.RegisterUser("username", "test@example.com", "alllowercase"));
        Assert.Throws<ArgumentException>(() => registration.RegisterUser("username", "test@example.com", "NOCAPS123"));
    }
}
