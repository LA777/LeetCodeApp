using FluentAssertions;
using LeetCodeDotNet.DynamicProgramming;

namespace UnitTests.DynamicProgramming;

public class HouseRobberTests
{
    private readonly HouseRobber _sut = new HouseRobber();

    [Theory]
    [InlineData(new[] { 9, 1, 1, 9, 9, 9}, 27)]
    [InlineData(new[] { 1, 9, 9, 1, 9, 9 }, 19)]
    [InlineData(new[] { 1, 2, 3, 1 }, 4)]
    [InlineData(new[] { 2, 7, 9, 3, 1 }, 12)]
    [InlineData(new[] { 4, 9, 2, 1, 5, 7, 8, 2 }, 22)]
    [InlineData(new[] { 4, 5, 2, 1, 3, 9, 9, 2 }, 18)]
    public void MiddleNode_Should_Work_As_Expected(int[] input, int output)
    {
        var actualOutput = _sut.Rob(input);

        actualOutput.Should().Be(output);
    }
}
