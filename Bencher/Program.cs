using BenchmarkDotNet.Running;
using Bencher.Benchmark;

namespace Bencher;

class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<StingConcatFunctionsBenchmark>();
    }
}

