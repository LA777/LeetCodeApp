using BenchmarkDotNet.Running;
using LeetCodeDotNet.Tasks;

namespace LeetCodeDotNet
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var summary = BenchmarkRunner.Run<Task1342>();
            Console.WriteLine(summary);
        }
    }
}
