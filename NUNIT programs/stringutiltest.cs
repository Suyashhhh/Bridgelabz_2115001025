public class StringUtils
{
    public string Reverse(string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    public bool IsPalindrome(string str)
    {
        string reversed = Reverse(str);
        return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }

    public string ToUpperCase(string str)
    {
        return str.ToUpper();
    }
}





using NUnit.Framework;

[TestFixture]
public class StringUtilsTests
{
    private StringUtils stringUtils;

    [SetUp]
    public void Setup()
    {
        stringUtils = new StringUtils();
    }

    [Test]
    public void Reverse_ShouldReturnReversedString()
    {
        string result = stringUtils.Reverse("hello");
        Assert.AreEqual("olleh", result);
    }

    [Test]
    public void IsPalindrome_ShouldReturnTrueForPalindrome()
    {
        bool result = stringUtils.IsPalindrome("madam");
        Assert.IsTrue(result);
    }

    [Test]
    public void IsPalindrome_ShouldReturnFalseForNonPalindrome()
    {
        bool result = stringUtils.IsPalindrome("hello");
        Assert.IsFalse(result);
    }

    [Test]
    public void ToUpperCase_ShouldReturnUpperCaseString()
    {
        string result = stringUtils.ToUpperCase("hello");
        Assert.AreEqual("HELLO", result);
    }
}
