using Bencher.Interfaces;

namespace Bencher.Functions.DependencyInjection;

public class ExampleService : IExampleService
{
    public int ExampleMethod()
    {
        int sum = 0;
        for (int i = 0; i < 100; i++)
        {
            sum++;
        }
        return sum;
    }
}