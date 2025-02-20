using FluentAssertions;
using LeetCodeDotNet.DynamicProgramming;

namespace UnitTests.DynamicProgramming;

public class MinCostClimbingStairs70Tests
{
    private readonly MinCostClimbingStairs70 _sut = new ();

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(4, 5)]
    [InlineData(5, 8)]
    public void ClimbStairs_Should_Work_As_Expected(int n, int output)
    {
        var actualOutput = _sut.ClimbStairs(n);

        actualOutput.Should().Be(output);
    }
}
