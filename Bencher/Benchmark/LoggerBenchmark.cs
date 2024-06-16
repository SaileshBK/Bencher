using Bencher.Functions;
using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Logging;

namespace Bencher.Benchmark;

[MemoryDiagnoser]
public class LoggerBenchmark
{
    private readonly ILogger<LoggerBenchmark> _logger;

    public LoggerBenchmark()
    {
        var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });
        _logger = loggerFactory.CreateLogger<LoggerBenchmark>();
    }

    [Benchmark]
    public void SimpleString()
    {
        Logger.SimpleString(_logger);
    }

    [Benchmark]
    public void Structured()
    {
        Logger.Structured(_logger);
    }

    [Benchmark]
    public void StringInterpolation()
    {
        Logger.StringInterpolation(_logger);
    }
}