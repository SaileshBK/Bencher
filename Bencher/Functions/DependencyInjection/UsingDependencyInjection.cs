using Bencher.Interfaces;

namespace Bencher.Functions.DependencyInjection;

public class UsingDependencyInjection
{
    private readonly IExampleService _exampleService;

    public UsingDependencyInjection(IExampleService exampleService)
    {
        _exampleService = exampleService;
    }

    public int  RunExampleMethod()
    {
        return _exampleService.ExampleMethod();
    }
}
