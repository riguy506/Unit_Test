//Solomon, Etikayo, and Riley 

using UnitTestEx;
using Xunit;

namespace UnitTestEXTest;

public class UnitTest1
{
    [Fact]
    public void TestMin6_17()
    {
        double expected = 6;
        double actual = UnitTestEx.Class1.Min(17,6);

        Assert.Equal(expected,actual);
    }

    [Fact]
    public void TestMin6_17_3()
    {
        double expected = 3;
        double actual = UnitTestEx.Class1.Min(17,6,3);

        Assert.Equal(expected,actual);
    }

}

