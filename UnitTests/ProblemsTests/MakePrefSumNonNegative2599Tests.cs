using FluentAssertions;
using LeetCodeDotNet.Problems;

namespace UnitTests.ProblemsTests;

public class MakePrefSumNonNegative2599Tests
{
    private readonly MakePrefSumNonNegative2599 _sut = new();

    [Theory]
    [InlineData(0, new int[] { })]
    [InlineData(0, new int[] { 2, 3, -5, 4 })]
    [InlineData(1, new int[] { 3, -5, -2, 6 })]
    [InlineData(4, new int[] { -3, -5, -2, -6 })]
    [InlineData(2, new int[] { 6, -5, 1, -3, 2, -7, 8 })]
    [InlineData(1, new int[] { 6, -6, -3, 3, 1, 5, -4, -3, -2, -3, 4, -1, 4, 4, -2, 6, 0 })]
    public void MakePrefSumNonNegative_Returns_Correct_Value(int expectedOperations, int[] nums)
    {
        // Arrange & Act
        var result = _sut.MakePrefSumNonNegative(nums);

        // Assert
        result.Should().Be(expectedOperations);
    }
}
