namespace Bencher.Functions.DependencyInjection;

public class NotUsingDependencyInjection
{
    public int RunExampleMethod()
    {
        var exampleService = new ExampleService();
        return exampleService.ExampleMethod();
    }
}
