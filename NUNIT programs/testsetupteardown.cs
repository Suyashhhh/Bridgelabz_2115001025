public class DatabaseConnection
{
    public bool IsConnected { get; private set; }

    public void Connect()
    {
        IsConnected = true;
    }

    public void Disconnect()
    {
        IsConnected = false;
    }
}







using NUnit.Framework;

[TestFixture]
public class DatabaseConnectionTests
{
    private DatabaseConnection dbConnection;

    [SetUp]
    public void Setup()
    {
        dbConnection = new DatabaseConnection();
        dbConnection.Connect();
    }

    [TearDown]
    public void Teardown()
    {
        dbConnection.Disconnect();
    }

    [Test]
    public void Connection_ShouldBeEstablished_AfterSetup()
    {
        Assert.IsTrue(dbConnection.IsConnected);
    }

    [Test]
    public void Connection_ShouldBeClosed_AfterTeardown()
    {
        Teardown(); // Manually call teardown to simulate end of test
        Assert.IsFalse(dbConnection.IsConnected);
    }
}
