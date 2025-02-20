namespace LeetCodeDotNet.Problems;

/// <summary>
/// https://leetcode.com/problems/make-the-prefix-sum-non-negative/description
/// </summary>
public class MakePrefSumNonNegative2599
{
    public int MakePrefSumNonNegative(int[] nums)
    {
        if (nums.Length < 1)
        {
            return 0;
        }

        var priorityQueue = new PriorityQueue<int, int>();
        var tailingOperationCount = 0;
        var prefixSum = 0;

        foreach (var number in nums)
        {
            if (number < 0)
            {
                priorityQueue.Enqueue(number, number);
            }

            prefixSum += number;

            if (prefixSum < 0 && priorityQueue.TryDequeue(out int element, out int priority))
            {
                prefixSum -= element;
                tailingOperationCount++;
            }
        }

        return tailingOperationCount;
    }
}
