﻿using BenchmarkDotNet.Running;
using Bencher.Benchmark;

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
        RunBenchmark<ControlFlowFunctionsBenchmark>();
    }

    public static void RunBenchmark<T>() where T : class
    {
        BenchmarkRunner.Run<T>();
    }
}

