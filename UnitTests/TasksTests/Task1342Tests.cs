using FluentAssertions;
using LeetCodeDotNet.Tasks;

namespace UnitTests.TasksTests
{
    public class Task1342Tests
    {
        private readonly Task1342 _sut = new Task1342();

        [Theory]
        [InlineData(14, 6)]
        [InlineData(8, 4)]
        [InlineData(123, 12)]
        public void RunningSum_Should_Work_As_Expected(int input, int output)
        {
            var actualOutput = _sut.NumberOfSteps(input);

            actualOutput.Should().Be(output);
        }
    }
}
