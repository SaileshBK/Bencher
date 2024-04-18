using BenchmarkDotNet.Attributes;
using Experiment.Functions;
using Experiment.Utilities;

namespace Experiment.Benchmark;

[MemoryDiagnoser]
public class StingConcatFunctionsBenchmark
{
    [Benchmark]
    public void MethodWithTake()
    {
        StingConcatFunctions.MethodWithTake(StringValues.TestString);
    }

    [Benchmark]
    public void MethodWithSubstring()
    {
        StingConcatFunctions.MethodWithSubstring(StringValues.TestString);
    }

    [Benchmark]
    public void MethodWithSlice()
    {
        StingConcatFunctions.MethodWithSlice(StringValues.TestString);
    }

    [Benchmark]
    public void MethodWithRange()
    {
        StingConcatFunctions.MethodWithRange(StringValues.TestString);
    }
}
