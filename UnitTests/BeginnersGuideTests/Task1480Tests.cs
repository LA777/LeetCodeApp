using FluentAssertions;
using LeetCodeDotNet.BeginnersGuide;

namespace UnitTests.BeginnersGuideTests
{
    public class Task1480Tests
    {
        private readonly Task1480 _sut = new Task1480();

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 3, 6, 10 })]
        [InlineData(new[] { 1, 1, 1, 1, 1 }, new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new[] { 3, 1, 2, 10, 1 }, new[] { 3, 4, 6, 16, 17 })]
        public void RunningSum_Should_Work_As_Expected(int[] input, int[] output)
        {
            var actualOutput = _sut.RunningSum(input);

            actualOutput.Should().BeEquivalentTo(output);
        }
    }
}
