namespace LeetCodeDotNet.DynamicProgramming;

/// <summary>
/// https://leetcode.com/problems/fibonacci-number/description
/// </summary>
public class FibonacciNumber509
{
    public int Fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        if (n > 30)
        {
            throw new ArgumentOutOfRangeException(nameof(n));
        }

        var previousNumber = 0;
        var currentNumber = 1;

        for (var i = currentNumber; i < n; i++)
        {
            currentNumber = previousNumber + currentNumber;
            previousNumber = currentNumber - previousNumber;
        }

        return currentNumber;
    }
}
