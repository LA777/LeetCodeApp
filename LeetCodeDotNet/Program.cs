using BenchmarkDotNet.Running;
using LeetCodeDotNet.Tasks;

namespace LeetCodeDotNet
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var summary = BenchmarkRunner.Run<Task412>();
            Console.WriteLine(summary);
        }
    }
}
