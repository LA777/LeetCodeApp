using FluentAssertions;
using LeetCodeDotNet.BeginnersGuide;

namespace UnitTests.BeginnersGuideTests
{
    public class Task876Tests
    {
        private readonly Task876 _sut = new Task876();

        [Theory]
        [InlineData(new[] { 1 }, new[] { 1 })]
        [InlineData(new[] { 1, 2 }, new[] { 2 })]
        [InlineData(new[] { 1, 2, 3 }, new[] { 2, 3 })]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 3, 4 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 3, 4, 5 })]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 4, 5, 6 })]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, new[] { 9, 10, 11, 12, 13, 14, 15, 16 })]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 }, new[] { 9, 10, 11, 12, 13, 14, 15, 16, 17 })]
        public void MiddleNode_Should_Work_As_Expected(int[] input, int[] output)
        {
            var listNodeHead = ConvertArrayToListNode(input);
            var listNodeHeadOutput = ConvertArrayToListNode(output);

            var actualOutput = _sut.MiddleNode(listNodeHead);

            actualOutput.Should().BeEquivalentTo(listNodeHeadOutput);
        }

        private ListNode ConvertArrayToListNode(int[] array)
        {
            var listNodeHead = new ListNode(array[0]);
            var lastElement = array[array.Length - 1];
            var nextNode = new ListNode(lastElement);

            for (int i = array.Length - 2; i >= 0; i--)
            {
                var value = array[i];
                var listNode = new ListNode(value, nextNode);
                nextNode = listNode;
                listNodeHead = listNode;
            }

            return listNodeHead;
        }
    }
}
