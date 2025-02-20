namespace LeetCodeDotNet.DynamicProgramming;

/// <summary>
/// https://leetcode.com/problems/house-robber/description
/// </summary>
public class HouseRobber
{
    public int Rob(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            return 0;
        }
        else if (numbers.Length == 1)
        {
            return numbers[0];
        }

        var digits = new int[numbers.Length];
        digits[0] = numbers[0];
        digits[1] = Max(numbers[0], numbers[1]);

        for (var i = 2; i < numbers.Length; i++)
        {
            digits[i] = Max(digits[i - 1], digits[i - 2] + numbers[i]);
        }

        return digits[digits.Length - 1];
    }

    private int Max(int a, int b)
    {
        return a > b ? a : b;
    }
}
