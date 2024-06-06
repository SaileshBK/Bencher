using Bencher.Functions;
using Bencher.Interfaces;
using Bencher.Utilities;
using BenchmarkDotNet.Attributes;

namespace Bencher.Benchmark
{
    [MemoryDiagnoser]
    public class AsyncTaskBenchmark
    {
        private IAsyncTask _asyncTask;


        // Setup method to initialize the AsyncTask instance
        [GlobalSetup]
        public void Setup()
        {
            _asyncTask = new AsyncTask();
        }

        [Benchmark]
        public async Task ExampleOneSecondAsync()
        {
            await _asyncTask.ExampleOneSecondAsync(Constants.TestString);
        }

        [Benchmark]
        public async Task ExampleHalfSecondAsync()
        {
            var asyncTask = new AsyncTask();
            await _asyncTask.ExampleHalfSecondAsync(Constants.TestString);
        }
    }
}
