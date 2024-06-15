using Bencher.Functions.DependencyInjection;
using Bencher.Interfaces;
using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace Bencher.Benchmark;

[MemoryDiagnoser]
public class DependencyInjectionBenchmark
{
    private NotUsingDependencyInjection? _notUsingDependencyInjection;
    private UsingDependencyInjection? _usingDependencyInjection;
    private ServiceProvider? _serviceProvider;

    [GlobalSetup]
    public void Setup()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddTransient<IExampleService, ExampleService>();
        _serviceProvider = serviceCollection.BuildServiceProvider();
        _usingDependencyInjection = new UsingDependencyInjection(_serviceProvider.GetService<IExampleService>()!);
        _notUsingDependencyInjection = new NotUsingDependencyInjection();

    }

    [Benchmark]
    public void UsingDependencyInjection()
    {
        _usingDependencyInjection?.RunExampleMethod();
    }

    [Benchmark]
    public void NotUsingDependencyInjection()
    {
        _notUsingDependencyInjection?.RunExampleMethod();
    }
}
