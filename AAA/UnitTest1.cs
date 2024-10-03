
namespace AAA;


public class UnitTest1
{
    [Fact]
    public void Success()
    {
        Assert.True(true);
    }
    [Fact(Skip = "This test was build to fail~")]
    public void Fail()
    {
        Assert.True(false);
    }
}