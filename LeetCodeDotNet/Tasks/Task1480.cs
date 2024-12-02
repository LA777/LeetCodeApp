namespace LeetCodeDotNet.Tasks
{
    /// <summary>
    /// https://leetcode.com/problems/running-sum-of-1d-array/description/
    /// </summary>
    public class Task1480
    {
        public int[] RunningSum(int[] nums)
        {
            int sum = 0;
            int numsLength = nums.Length;
            var output = new int[numsLength];

            for (int i = 0; i < numsLength; i++)
            {
                sum += nums[i];
                output[i] = sum;
            }

            return output;
        }
    }
}
