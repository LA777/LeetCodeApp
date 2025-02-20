using FluentAssertions;
using LeetCodeDotNet.DynamicProgramming;

namespace UnitTests.DynamicProgramming;

public class TribonacciNumber1137Tests
{
    private readonly TribonacciNumber1137 _sut = new ();

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 4)]
    [InlineData(25, 1389537)]

    public void Fib_Should_Work_As_Expected(int input, int output)
    {
        var actualOutput = _sut.Tribonacci(input);

        actualOutput.Should().Be(output);
    }
}
