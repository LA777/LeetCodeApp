using FluentAssertions;
using LeetCodeDotNet.Problems;

namespace UnitTests.ProblemsTests;

public class DistinctNumbersInEachSubarray1852Tests
{
    private readonly DistinctNumbersInEachSubarray1852 _sut = new();

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 2, 2, 1, 3 }, 3, new int[] { 3, 2, 2, 2, 3 })]
    [InlineData(new int[] { 1, 1, 1, 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4 })]
    public void DistinctNumbers_Returns_Correct_Value(int[] nums, int k, int[] expectedAray)
    {
        // Arrange & Act
        var result = _sut.DistinctNumbers(nums, k);

        // Assert
        result.Should().BeEquivalentTo(expectedAray);
    }
}
