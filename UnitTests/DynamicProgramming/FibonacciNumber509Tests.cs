using FluentAssertions;
using LeetCodeDotNet.DynamicProgramming;

namespace UnitTests.DynamicProgramming;

public class FibonacciNumber509Tests
{
    private readonly FibonacciNumber509 _sut = new ();

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    [InlineData(5, 5)]
    [InlineData(6, 8)]
    public void Fib_Should_Work_As_Expected(int input, int output)
    {
        var actualOutput = _sut.Fib(input);

        actualOutput.Should().Be(output);
    }
}
