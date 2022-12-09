using Xunit;
using greeting;

namespace greeting_tests;

public class GreetTest
{
    [Theory]
    [InlineData("Oliver", "Hello, Oliver!")]
    [InlineData("", "Hello, World!")]
    public void HappyPaths(string name, string expected)
    {
        var actual = Greeting.Greet(name);

        Assert.Equal(expected, actual);
    }
}