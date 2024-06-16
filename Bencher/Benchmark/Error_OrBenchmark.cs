using Bencher.Functions;
using Bencher.Interfaces;
using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace Bencher.Benchmark;

[MemoryDiagnoser]
public class Error_OrBenchmark
{
    private IError_Or? _error_Or;

    [GlobalSetup]
    public void Setup()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<IError_Or, Error_Or>();
        _error_Or = serviceCollection.BuildServiceProvider().GetService<IError_Or>();
    }

    [Benchmark]
    public string UsingError_Or()
    {
        return _error_Or?.UsingError_Or()!;
    }

    [Benchmark]
    public string NotUsingError_Or()
    {
        return _error_Or?.NotUsingError_Or()!;
    }
}

