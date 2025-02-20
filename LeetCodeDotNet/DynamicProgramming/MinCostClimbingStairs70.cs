namespace LeetCodeDotNet.DynamicProgramming;

/// <summary>
/// https://leetcode.com/problems/climbing-stairs/description
/// </summary>
public class MinCostClimbingStairs70
{
    public int ClimbStairs(int n)
    {
        if(n <= 0)
        {
            return 0;
        }

        if (n < 4)
        {
            return n;
        }

        if (n > 45)
        {
            throw new ArgumentOutOfRangeException(nameof(n));
        }

        var previousNumber = 2;
        var currentNumber = 3;

        for (var i = currentNumber; i < n; i++)
        {
            currentNumber = previousNumber + currentNumber;
            previousNumber = currentNumber - previousNumber;
        }

        return currentNumber;
    }
}
