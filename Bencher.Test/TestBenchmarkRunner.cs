using Bencher.Benchmark;
using BenchmarkDotNet.Running;

namespace Bencher.Test
{
    public class TestBenchmarkRunner
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RunBenchmarks()
        {
            var summary = BenchmarkRunner.Run<AsyncTaskBenchmark>();
        }
    }
}