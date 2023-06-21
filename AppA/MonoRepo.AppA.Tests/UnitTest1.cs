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
        Task.Delay(11000);
        Assert.Pass();
    }
}