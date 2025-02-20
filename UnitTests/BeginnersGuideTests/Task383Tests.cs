using FluentAssertions;
using LeetCodeDotNet.BeginnersGuide;

namespace UnitTests.BeginnersGuideTests;

public class Task383Tests
{
    private readonly Task383 _sut = new Task383();

    [Theory]
    [InlineData("a", "b", false)]
    [InlineData("aa", "ab", false)]
    [InlineData("aa", "aab", true)]
    public void CanConstruct_Should_Work_As_Expected(string ransomNote, string magazine,
        bool expectedOutput)
    {
        var actualOutput = _sut.CanConstruct(ransomNote, magazine);

        actualOutput.Should().Be(expectedOutput);
    }

    [Theory]
    [InlineData("a", "b", false)]
    [InlineData("aa", "ab", false)]
    [InlineData("aa", "aab", true)]
    public void CanConstructWithArray_Should_Work_As_Expected(string ransomNote, string magazine,
        bool expectedOutput)
    {
        var actualOutput = _sut.CanConstructWithArray(ransomNote, magazine);

        actualOutput.Should().Be(expectedOutput);
    }
}
