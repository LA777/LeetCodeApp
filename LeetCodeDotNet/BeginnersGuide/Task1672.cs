namespace LeetCodeDotNet.BeginnersGuide;

/// <summary>
/// https://leetcode.com/problems/richest-customer-wealth/description/
/// </summary>
public class Task1672
{
    public int MaximumWealth(int[][] accounts)
    {
        var max = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            var sum = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                sum += accounts[i][j];
            }
            if (sum > max)
            {
                max = sum;
            }
        }

        return max;
    }
}
