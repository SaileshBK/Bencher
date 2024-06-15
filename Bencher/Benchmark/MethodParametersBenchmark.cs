using Bencher.Dummy.Classes;
using Bencher.Functions;
using BenchmarkDotNet.Attributes;

namespace Bencher.Benchmark;

[MemoryDiagnoser]
public class MethodParametersBenchmark
{
    [Benchmark]
    public void NotUsingRef()
    {
        var test = new TestRefClass();
        MethodParameters.MethodWithoutRef(test);
    }

    [Benchmark]
    public void UsingRef()
    {
        var test = new TestRefClass();
        MethodParameters.MethodWithRef(ref test);
    }
}