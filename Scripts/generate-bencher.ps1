$InputFile = "Test"
$InterfaceFile = "I${InputFile}.cs"
$BenchmarkFile = "${InputFile}Benchmark.cs"


# Extract class name from the input file
$ClassName = (Select-String -Path "${InputFile}.cs" -Pattern 'public class (\w+)' | ForEach-Object { $_.Matches.Groups[1].Value })


# Extract methods from the input file
$Methods = (Select-String -Path "${InputFile}.cs" -Pattern 'public async Task<string> (\w+)\(.*\)' | ForEach-Object { $_.Matches.Groups[1].Value })


# Generate interface file
@"
namespace Bencher.Interfaces;

    public interface I$ClassName
    {
"@ > $InterfaceFile
foreach ($method in $Methods) {
    "        Task<string> $method(string data);" >> $InterfaceFile
}
    "}" >> $InterfaceFile


# Generate benchmark class file
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
"@ > $BenchmarkFile


foreach ($method in $Methods) {
    @"

        [Benchmark]
        public async Task $method()
        {
            await _$ClassNameLower.$method(Constants.TestString);
        }

"@ >> $BenchmarkFile
}


"}" >> $BenchmarkFile


dotnet tool install -g dotnet-format


dotnet-format $InterfaceFile
dotnet-format $BenchmarkFile


Write-Output "Files $InterfaceFile and $BenchmarkFile generated."