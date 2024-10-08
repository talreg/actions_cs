namespace Console.tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }

    [Fact (Skip="This test is expected to fail")]
    public void FailureTest()
    {
        Assert.True(false);
    }
}