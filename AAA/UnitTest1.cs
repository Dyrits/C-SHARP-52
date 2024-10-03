
namespace AAA;


public class UnitTest1
{
    [Fact]
    public void OK()
    {
        Assert.Equal(3, Add(1, 2));
    }

    int Add(int numberA, int numberB)
    {
        return numberA + numberB;
    }
}