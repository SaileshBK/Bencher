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
