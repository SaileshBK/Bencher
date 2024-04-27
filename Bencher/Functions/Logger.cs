using System;
using Bencher.Benchmark;
using Microsoft.Extensions.Logging;

namespace Bencher.Functions
{
    internal static class Logger
    {
        public static void Structured(ILogger<LoggerBenchmark> logger)
        {

            logger.LogInformation("Logging current position {Position}", Random.Shared.Next());

        }

        public static void SimpleString(ILogger<LoggerBenchmark> logger)
        {

            logger.LogInformation("Logging current position " + Random.Shared.Next());

        }

        public static void StringInterpolation(ILogger<LoggerBenchmark> logger)
        {

            logger.LogInformation($"Logging current position {Random.Shared.Next()}");

        }
    }
}
