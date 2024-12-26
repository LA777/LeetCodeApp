using BenchmarkDotNet.Attributes;

namespace LeetCodeDotNet.BeginnersGuide
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
    /// </summary>
    public class Task1342
    {
        private readonly int _number = 89;

        [Benchmark(Baseline = true)]
        public void RunNumberOfSteps() => NumberOfSteps(_number);

        [Benchmark]
        public void RunNumberOfStepsWithWhile() => NumberOfStepsWithWhile(_number);

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

        public int NumberOfStepsWithWhile(int num)
        {
            int steps = 0;

            while (num > 0)
            {
                num = (num % 2 == 0) ? num / 2 : num - 1;
                steps++;
            }

            return steps;
        }
    }
}
