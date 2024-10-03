
namespace AAA;


public class UnitTest1
{
    [Fact]
    public void Success()
    {
        Assert.True(true);
    }

    [Fact]
    public void Fail()
    {
        Assert.True(false);
    }
}