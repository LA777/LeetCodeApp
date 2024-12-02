using FluentAssertions;
using LeetCodeDotNet.Tasks;

namespace UnitTests.TasksTests
{
    public class Task412Tests
    {
        private readonly Task412 _sut = new Task412();

        [Theory]
        [InlineData(3, new[] { "1", "2", "Fizz" })]
        [InlineData(5, new[] { "1", "2", "Fizz", "4", "Buzz" })]
        [InlineData(15, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
        public void FizzBuzz_Should_Work_As_Expected(int input, string[] expectedOutput)
        {
            var actualOutput = _sut.FizzBuzz(input);

            actualOutput.Should().BeEquivalentTo(expectedOutput);
        }

        [Theory]
        [InlineData(3, new[] { "1", "2", "Fizz" })]
        [InlineData(5, new[] { "1", "2", "Fizz", "4", "Buzz" })]
        [InlineData(15, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
        public void FizzBuzz2_Should_Work_As_Expected(int input, string[] expectedOutput)
        {
            var actualOutput = _sut.FizzBuzz2(input);

            actualOutput.Should().BeEquivalentTo(expectedOutput);
        }
    }
}
