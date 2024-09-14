Set-Location -Path $PSScriptRoot

$InputFile = "Test"
$InterfaceFile = "I${InputFile}.cs"
$BenchmarkFileName = "${InputFile}Benchmark.cs"


# Extract class name from the input file
$ClassName = (Select-String -Path "${InputFile}.cs" -Pattern 'public class (\w+)' | ForEach-Object { $_.Matches.Groups[1].Value })


# Extract methods from the input file
$Methods = (Select-String -Path "${InputFile}.cs" -Pattern 'public async Task<string> (\w+)\(.*\)' | ForEach-Object { $_.Matches.Groups[1].Value })

# Generate interface file
. ./FileModels/interface-file.ps1 -InterfaceFileName $InterfaceFile -ClassName $ClassName -Methods $Methods


# Generate benchmark class file
. ./FileModels/benchmark-file.ps1 -BenchmarkFileName $BenchmarkFileName -ClassName $ClassName -Methods $Methods

dotnet tool install -g dotnet-format
dotnet-format $InterfaceFile
dotnet-format $BenchmarkFileName

Write-Output "Files $InterfaceFile and $BenchmarkFileName generated."