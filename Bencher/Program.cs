﻿using Bencher.Benchmark;
using BenchmarkDotNet.Running;

namespace Bencher;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * To run the Benchmark Simply pass the benchmark class and run it
         * on Release mode.
         * For example : RunBenchmark<ClassNeedToBenchMark>();
         */

        //RunBenchmark<StingConcatFunctionsBenchmark>();
        //RunBenchmark<ControlFlowFunctionsBenchmark>();
        //RunBenchmark<ControlFlowWithGenericFunctionsBenchmark>();
        //RunBenchmark<LoggerBenchmark>();
        //RunBenchmark<MethodParametersBenchmark>();
        //RunBenchmark<AsyncTaskBenchmark>();
        //RunBenchmark<DependencyInjectionBenchmark>();
        //RunBenchmark<Error_OrBenchmark>();

        // Test Function Outputs
        //FunctionVerifier.Verify(Function.MethodParameters);
    }

    public static void RunBenchmark<T>() where T : class
    {
        BenchmarkRunner.Run<T>();
    }
}