namespace MonoRepo.AppA.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Task.Delay(1000);
        Assert.False(false);
    }
}