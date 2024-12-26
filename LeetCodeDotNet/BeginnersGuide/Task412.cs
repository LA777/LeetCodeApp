using BenchmarkDotNet.Attributes;

namespace LeetCodeDotNet.BeginnersGuide
{
    /// <summary>
    /// https://leetcode.com/problems/fizz-buzz/
    /// </summary>
    public class Task412
    {
        private readonly int _number = 345;

        [Benchmark(Baseline = true)]
        public void RunFizzBuzz() => FizzBuzz(_number);

        [Benchmark]
        public void RunFizzBuzz2() => FizzBuzz2(_number);

        public IList<string> FizzBuzz(int n)
        {
            return FizzBuzzRecursive(n, 1, []);
        }

        public IList<string> FizzBuzzRecursive(int n, int currentNumber, IList<string> output)
        {
            if (currentNumber > n)
            {
                return output;
            }

            if (currentNumber % 15 == 0)
            {
                output.Add("FizzBuzz");
            }
            else if (currentNumber % 3 == 0)
            {
                output.Add("Fizz");
            }
            else if (currentNumber % 5 == 0)
            {
                output.Add("Buzz");
            }
            else
            {
                output.Add(currentNumber.ToString());
            }

            currentNumber++;
            return FizzBuzzRecursive(n, currentNumber, output);
        }

        public IList<string> FizzBuzz2(int n)
        {
            var output = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    output.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    output.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    output.Add("Buzz");
                }
                else
                {
                    output.Add(i.ToString());
                }
            }

            return output;
        }
    }
}
