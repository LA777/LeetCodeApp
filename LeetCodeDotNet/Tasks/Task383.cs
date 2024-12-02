using BenchmarkDotNet.Attributes;

namespace LeetCodeDotNet.Tasks
{
    /// <summary>
    /// https://leetcode.com/problems/ransom-note/description/
    /// </summary>
    public class Task383
    {
        private readonly string _ransomNote = "aa";
        private readonly string _magazine = "aab";

        [Benchmark]
        public void RunCanConstruct() => CanConstruct(_ransomNote, _magazine);

        [Benchmark(Baseline = true)]
        public void RunCanConstructWithArray() => CanConstructWithArray(_ransomNote, _magazine);

        public bool CanConstruct(string ransomNote, string magazine)
        {
            var dict = new Dictionary<char, int>();

            for (int i = 0; i < magazine.Length; i++)
            {
                if (dict.ContainsKey(magazine[i]))
                {
                    dict[magazine[i]]++;
                }
                else
                {
                    dict[magazine[i]] = 1;
                }
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (dict.ContainsKey(ransomNote[i]) && dict[ransomNote[i]] > 0)
                {
                    dict[ransomNote[i]]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public bool CanConstructWithArray(string ransomNote, string magazine)
        {
            const int maxChars = 26;
            const char a = 'a';
            var charArray = new int[maxChars];
            var ransomNoteLength = ransomNote.Length;
            for (int i = 0; i < ransomNoteLength; i++)
            {
                charArray[ransomNote[i] - a]++;
            }

            for (int i = 0; i < magazine.Length; i++)
            {
                if (charArray[magazine[i] - a] > 0)
                {
                    ransomNoteLength--;
                    charArray[magazine[i] - a]--;
                    if (ransomNoteLength == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
