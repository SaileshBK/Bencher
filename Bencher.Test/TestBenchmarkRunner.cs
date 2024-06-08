using Bencher.Benchmark;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

namespace Bencher.Test
{
    public class TestBenchmarkRunner
    {
        public IConfig _config;

        [SetUp]
        public void Setup()
        {
            _config = DefaultConfig.Instance
                .WithOption(ConfigOptions.DisableLogFile, false)
                .WithOption(ConfigOptions.KeepBenchmarkFiles, false)
                .WithOption(ConfigOptions.JoinSummary, true);
        }

        [Test]
        public void RunBenchmarks()
        {
            var summary = BenchmarkRunner.Run<AsyncTaskBenchmark>(_config);
            AssertBenchmarkResults(summary);
        }

        private void AssertBenchmarkResults(Summary summary)
        {
            var exampleOneSecondAsync = summary.Reports.FirstOrDefault(r => 
                r.BenchmarkCase.Descriptor.WorkloadMethod.Name == nameof(AsyncTaskBenchmark.ExampleOneSecondAsync));
            var exampleHalfSecondAsync = summary.Reports.FirstOrDefault(r => 
                r.BenchmarkCase.Descriptor.WorkloadMethod.Name == nameof(AsyncTaskBenchmark.ExampleHalfSecondAsync));

            var resultExpectation = "ExampleHalfSecondAsync should allocate same memory as ExampleOneSecondAsync";
            Assert.That(exampleOneSecondAsync, Is.Not.Null);
            Assert.That(exampleHalfSecondAsync, Is.Not.Null);
            Assert.True(exampleHalfSecondAsync.Metrics["Allocated Memory"].Value == exampleOneSecondAsync.Metrics["Allocated Memory"].Value, resultExpectation);
        }
    }
}