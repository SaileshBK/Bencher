using BenchmarkDotNet.Running;
using Bencher.Benchmark;
using Microsoft.Extensions.Logging;
using BenchmarkDotNet.Engines;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Bencher;

class Program
{
    static void Main(string[] args)
    {
        /*
         * To run the Benchmark Simply pass the benchmark class and run it
         * on Release mode. 
         * For example : RunBenchmark<ClassNeedToBenchMark>();
         */

        //RunBenchmark<StingConcatFunctionsBenchmark>();
        //RunBenchmark<ControlFlowFunctionsBenchmark>();
        //RunBenchmark<ControlFlowWithGenericFunctionsBenchmark>();


        RunBenchmark<LoggerBenchmark>();

    }

    public static void RunBenchmark<T>() where T : class
    {
        BenchmarkRunner.Run<T>();
    }
}

