using BenchmarkDotNet.Running;
using Bencher.Benchmark;

namespace Bencher;

public static class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<StingConcatFunctionsBenchmark>();
    }
}

