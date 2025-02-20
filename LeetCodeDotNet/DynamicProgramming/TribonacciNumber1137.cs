namespace LeetCodeDotNet.DynamicProgramming;

/// <summary>
/// https://leetcode.com/problems/n-th-tribonacci-number/description
/// </summary>
public class TribonacciNumber1137
{
    public int Tribonacci(int n)
    {
        const int length = 3;

        if (n <= 1)
        {
            return n;
        }

        if (n <= 3)
        {
            return n - 1;
        }

        if (n > 37)
        {
            throw new ArgumentOutOfRangeException(nameof(n));
        }

        var array = new int[length] { 1, 1, 2 };
        var result = 0;

        for (var i = length; i < n; i++)
        {
            result = array.Sum();
            array[i % length] = result;
        }

        return result;
    }
}
