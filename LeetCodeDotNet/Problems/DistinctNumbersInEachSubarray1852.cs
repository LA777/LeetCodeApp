namespace LeetCodeDotNet.Problems;

/// <summary>
/// https://leetcode.com/problems/distinct-numbers-in-each-subarray
/// </summary>
public class DistinctNumbersInEachSubarray1852
{
    public int[] DistinctNumbers(int[] nums, int k)
    {
        var outputArrayLength = nums.Length - k + 1;
        var outputArray = new int[outputArrayLength];
        var frequencyMap = new Dictionary<int, int>();

        for (var i = 0; i < k; i++)
        {
            frequencyMap.TryGetValue(nums[i], out int count);
            frequencyMap[nums[i]] = count + 1;
        }

        outputArray[0] = frequencyMap.Count;

        for (var pos = k; pos < nums.Length; pos++)
        {
            var leftNum = nums[pos - k];
            frequencyMap[leftNum]--;

            if (frequencyMap[leftNum] == 0)
            {
                frequencyMap.Remove(leftNum);
            }

            var rightNum = nums[pos];
            frequencyMap.TryGetValue(rightNum, out int count);
            frequencyMap[rightNum] = count + 1;
            outputArray[pos - k + 1] = frequencyMap.Count;
        }

        return outputArray;
    }

    public int[] DistinctNumbersV1(int[] nums, int k)
    {
        var outputArrayLength = nums.Length - k + 1;
        var outputArray = new int[outputArrayLength];
        var hashSet = new HashSet<int>();

        for (var i = 0; i < outputArrayLength; i++)
        {
            var subArrayLength = k + i;

            for (var j = i; j < subArrayLength; j++)
            {
                hashSet.Add(nums[j]);
            }

            outputArray[i] = hashSet.Count;
            hashSet.Clear();
        }

        return outputArray;
    }
}
