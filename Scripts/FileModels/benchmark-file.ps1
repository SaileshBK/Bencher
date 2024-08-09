param(
    [string]$BenchmarkFileName,
    [string]$ClassName,
    [Array]$Methods
)

$ClassNameLower = $ClassName.ToLower()


@"
using Bencher.Functions;
using Bencher.Interfaces;
using Bencher.Utilities;
using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace Bencher.Benchmark;

    [MemoryDiagnoser]
    public class ${ClassName}Benchmark
    {
        private I$ClassName _$ClassNameLower;

        [GlobalSetup]
        public void Setup()
        {
            // Set up the DI container
            var serviceProvider = new ServiceCollection()
                .AddSingleton<I$ClassName, $ClassName>()
                .BuildServiceProvider();

            // Resolve the dependency
            _$ClassNameLower = serviceProvider.GetRequiredService<I$ClassName>();
        }
"@ > $BenchmarkFileName


foreach ($method in $Methods) {
    @"

        [Benchmark]
        public async Task $method()
        {
            await _$ClassNameLower.$method(Constants.TestString);
        }

"@ >> $BenchmarkFileName
}


"}" >> $BenchmarkFileName
