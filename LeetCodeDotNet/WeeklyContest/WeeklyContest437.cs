namespace LeetCodeDotNet.WeeklyContest;

/// <summary>
/// https://leetcode.com/contest/weekly-contest-437/problems/find-special-substring-of-length-k/description/
/// </summary>
public class WeeklyContest437
{
    public bool HasSpecialSubstringV1(string? s, int k)
    {
        if (s == null || s.Length < k || k <= 0)
        {
            return false;
        }

        for (var i = 0; i <= s.Length - k; i++)
        {
            var sub = s.Substring(i, k);
            var allSame = true;
            var firstChar = sub[0];

            for (var j = 1; j < k; j++)
            {
                if (sub[j] != firstChar)
                {
                    allSame = false;
                    break;
                }
            }

            if (allSame)
            {
                var beforeDifferent = true;
                if (i > 0)
                {
                    beforeDifferent = s[i - 1] != firstChar;
                }

                var afterDifferent = true;
                if (i + k < s.Length)
                {
                    afterDifferent = s[i + k] != firstChar;
                }

                if (beforeDifferent && afterDifferent)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public bool HasSpecialSubstringV2(string? s, int k)
    {
        if (s == null || s.Length < k || k <= 0)
        {
            return false;
        }

        if (k == 1 && s.Length == 1)
        {
            return true;
        }

        var tempChar = s[0];
        var countSameChars = 1;
        var afterDifferent = false;

        for (var i = 1; i < s.Length; i++)
        {
            if (tempChar == s[i])
            {
                countSameChars++;
            }
            else
            {
                countSameChars = 1;
                tempChar = s[i];
                afterDifferent = true;
            }

            if (countSameChars == k)
            {
                if (k == s.Length)
                {
                    return true;
                }
                else if(i == s.Length - 1 && afterDifferent)
                {
                    return true;
                }
                else if (i <= s.Length - 1)
                {
                    if (s[i] != s[i + 1])
                    {
                        return true;
                    }
                    else if (k == 1 && afterDifferent)
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }
}

