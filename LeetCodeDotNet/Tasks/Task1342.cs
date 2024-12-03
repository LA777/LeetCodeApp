namespace LeetCodeDotNet.Tasks
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
    /// </summary>
    public class Task1342
    {
        public int NumberOfSteps(int num)
        {
            return Recursion(num, 0);
        }

        private int Recursion(int number, int step)
        {
            if (number < 1)
            {
                return step;
            }

            if (number % 2 == 0)
            {
                number = number / 2;
            }
            else
            {
                number--;
            }

            step++;

            return Recursion(number, step);
        }
    }
}
