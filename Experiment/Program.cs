using BenchmarkDotNet.Running;
using Experiment.Benchmark;

namespace Experiment;

public static class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<StingConcatFunctionsBenchmark>();
    }
}

