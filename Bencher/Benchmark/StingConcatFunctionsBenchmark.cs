using BenchmarkDotNet.Attributes;
using Bencher.Functions;
using Bencher.Utilities;

namespace Bencher.Benchmark;

[MemoryDiagnoser]
public class StingConcatFunctionsBenchmark
{
    [Benchmark]
    public void MethodWithTake()
    {
        StingConcatFunctions.MethodWithTake(Constants.TestString);
    }

    [Benchmark]
    public void MethodWithSubstring()
    {
        StingConcatFunctions.MethodWithSubstring(Constants.TestString);
    }

    [Benchmark]
    public void MethodWithSlice()
    {
        StingConcatFunctions.MethodWithSlice(Constants.TestString);
    }

    [Benchmark]
    public void MethodWithRange()
    {
        StingConcatFunctions.MethodWithRange(Constants.TestString);
    }
}
