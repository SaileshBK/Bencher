using Bencher.Functions;
using Bencher.Utilities;
using BenchmarkDotNet.Attributes;

namespace Bencher.Benchmark;

[MemoryDiagnoser]
public class StingConcatFunctionsBenchmark
{
    [Benchmark]
    public void UsingTake()
    {
        StingConcatFunctions.MethodWithTake(Constants.TestString);
    }

    [Benchmark]
    public void UsingSubstring()
    {
        StingConcatFunctions.MethodWithSubstring(Constants.TestString);
    }

    [Benchmark]
    public void UsingSlice()
    {
        StingConcatFunctions.MethodWithSlice(Constants.TestString);
    }

    [Benchmark]
    public void UsingRange()
    {
        StingConcatFunctions.MethodWithRange(Constants.TestString);
    }
}