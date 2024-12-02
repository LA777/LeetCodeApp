using FluentAssertions;
using LeetCodeDotNet.Tasks;

namespace UnitTests.TasksTests
{
    public class Task1672Tests
    {
        private readonly Task1672 _sut = new Task1672();

        [Theory]
        [InlineData(6, new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
        [InlineData(10, new[] { 1, 5 }, new[] { 7, 3 }, new[] { 3, 5 })]
        [InlineData(17, new[] { 2, 8, 7 }, new[] { 7, 1, 3 }, new[] { 1, 9, 5 })]
        public void MaximumWealth_Should_Work_As_Expected(int expectedOutput, params int[][] accounts)
        {
            var actualOutput = _sut.MaximumWealth(accounts);

            actualOutput.Should().Be(expectedOutput);
        }
    }
}
