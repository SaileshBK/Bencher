using System.Diagnostics;
using BenchmarkDotNet.Running;
using Experiment.Benchmark.Methods;

namespace Experiment
{
    public static class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<StringTest>();
        }
    }
}

