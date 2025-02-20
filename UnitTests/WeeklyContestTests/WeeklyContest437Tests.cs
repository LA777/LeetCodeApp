using FluentAssertions;
using LeetCodeDotNet.WeeklyContest;

namespace UnitTests.WeeklyContest;

public class WeeklyContest437Tests
{
    private readonly WeeklyContest437 _sut = new();

    [Theory]
    [InlineData("aaabaaa", 3, true)]
    [InlineData("aaab", 3, true)]
    [InlineData("baaa", 3, true)]
    [InlineData("a", 1, true)]
    [InlineData("dii", 1, true)]
    [InlineData("aaaa", 4, true)]
    [InlineData("aabbcc", 2, true)]
    [InlineData("abc", 2, false)]
    [InlineData("", 2, false)]
    [InlineData("aaa", 0, false)]
    [InlineData("aaa", 2, false)]
    [InlineData("aa", 3, false)]
    [InlineData("aa", 1, false)]
    [InlineData(null, 2, false)]
    public void HasSpecialSubstringV1_Returns_Correct_Value(string? s, int k, bool expected)
    {
        // Arrange & Act
        bool result = _sut.HasSpecialSubstringV1(s, k);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("aaabaaa", 3, true)]
    [InlineData("aaab", 3, true)]
    [InlineData("baaa", 3, true)]
    [InlineData("a", 1, true)]
    [InlineData("dii", 1, true)]
    [InlineData("aaaa", 4, true)]
    [InlineData("aabbcc", 2, true)]
    [InlineData("abc", 2, false)]
    [InlineData("", 2, false)]
    [InlineData("aaa", 0, false)]
    [InlineData("aaa", 2, false)]
    [InlineData("aa", 3, false)]
    [InlineData("aa", 1, false)]
    [InlineData(null, 2, false)]
    public void HasSpecialSubstringV2_Returns_Correct_Value(string? s, int k, bool expected)
    {
        // Arrange & Act
        bool result = _sut.HasSpecialSubstringV2(s, k);

        // Assert
        result.Should().Be(expected);
    }
}
