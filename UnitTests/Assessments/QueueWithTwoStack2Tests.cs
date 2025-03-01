using AutoFixture;
using FluentAssertions;
using static LeetCodeDotNet.Assessments.QueueWithTwoStack2;

namespace UnitTests.Assessments
{
    public class QueueWithTwoStack2Tests: TestBase
    {
        [Theory]
        [InlineData(5)]
        [InlineData(25)]
        [InlineData(100)]
        public void QueueWithTwoStack2_Should_Work_As_Expected(int countOfElements)
        {
            var numbers = _fixture.CreateMany<int>(countOfElements).ToList();

            var sut = new MyQueue();

            sut.Empty().Should().BeTrue();

            foreach (var number in numbers)
            {
                sut.Push(number);
            }

            sut.Empty().Should().BeFalse();

            var elementPeek = sut.Peek();
            elementPeek.Should().Be(numbers[0]);

            for (var i = 0; i < numbers.Count; i++)
            {
                var elelemntPop = sut.Pop();
                elelemntPop.Should().Be(numbers[i]);
            }

            sut.Empty().Should().BeTrue();
        }
    }
}
