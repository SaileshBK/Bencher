using Bencher.Functions;
using Bencher.Interfaces;
using Bencher.Utilities;
using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace Bencher.Benchmark
{
    [MemoryDiagnoser]
    public class AsyncTaskBenchmark
    {
        private IAsyncTask _asyncTask;

        [GlobalSetup]
        public void Setup()
        {
            // Set up the DI container
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IAsyncTask, AsyncTask>()
                .BuildServiceProvider();

            // Resolve the dependency
            _asyncTask = serviceProvider.GetRequiredService<IAsyncTask>();
        }

        [Benchmark]
        public async Task ExampleOneSecondAsync()
        {
            await _asyncTask.ExampleOneSecondAsync(Constants.TestString);
        }

        [Benchmark]
        public async Task ExampleHalfSecondAsync()
        {
            await _asyncTask.ExampleHalfSecondAsync(Constants.TestString);
        }
    }
}
