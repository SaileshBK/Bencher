# Run
    /*
     * To run the Benchmark, Open Program.cs. Simply pass the benchmark class and run it
     * on Release mode. 
     * For example : RunBenchmark<ClassNeedToBenchMark>();
     */

# Summary
BenchmarkDotNet v0.13.12, Windows 10
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK 7.0.100
  [Host]     : .NET 7.0.16 (7.0.1624.6629), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

## StingConcatFunctions

| Method              | Mean     | Error    | StdDev   | Gen0   | Allocated |
|-------------------- |---------:|---------:|---------:|-------:|----------:|
| UsingTake      | 49.71 ns | 0.428 ns | 0.401 ns | 0.0167 |     280 B |
| UsingSubstring | 30.90 ns | 0.570 ns | 0.476 ns | 0.0086 |     144 B |
| UsingSlice     | 18.51 ns | 0.253 ns | 0.224 ns | 0.0086 |     144 B |
| UsingRange     | 19.38 ns | 0.409 ns | 0.546 ns | 0.0086 |     144 B |


## ControlFlowFunctions

| Method                     | Mean      | Error     | StdDev    | Median    | Allocated |
|--------------------------- |----------:|----------:|----------:|----------:|----------:|
| UsingIfAndElse        | 2.5309 ns | 0.0059 ns | 0.0049 ns | 2.5308 ns |         - |
| UsingSwitch           | 0.0052 ns | 0.0088 ns | 0.0074 ns | 0.0015 ns |         - |
| UsingSwitchExpression | 0.0016 ns | 0.0046 ns | 0.0038 ns | 0.0000 ns |         - |

## ControlFlowWithGenericFunctions

| Method                     | Mean      | Error    | StdDev   | Allocated |
|--------------------------- |----------:|---------:|---------:|----------:|
| UsingIfAndElse        |  31.99 ns | 0.163 ns | 0.152 ns |         - |
| UsingSwitch           | 110.30 ns | 0.673 ns | 0.630 ns |         - |
| UsingSwitchExpression | 107.93 ns | 0.293 ns | 0.274 ns |         - |

## Logger

| Method              | Mean     | Error   | StdDev  | Allocated |
|-------------------- |---------:|--------:|--------:|----------:|
| SimpleString        | 142.9 us | 2.07 us | 1.84 us |     340 B |
| Structured          | 143.9 us | 2.27 us | 2.01 us |     351 B |
| StringInterpolation | 144.0 us | 1.39 us | 1.30 us |     295 B |

## MethodParameters

| Method           | Mean     | Error     | StdDev    | Gen0   | Allocated |
|----------------- |---------:|----------:|----------:|-------:|----------:|
| NotUsingRef | 3.985 ns | 0.0501 ns | 0.0444 ns | 0.0014 |      24 B |
| UsingRef    | 4.027 ns | 0.0980 ns | 0.1048 ns | 0.0014 |      24 B |

## AsyncTask

| Method       | Mean       | Error   | StdDev  | Allocated |
|------------- |-----------:|--------:|--------:|----------:|
| ExampleOneSecondAsync | 1,009.5 ms | 4.98 ms | 4.66 ms |   7.44 KB |
| ExampleHalfSecondAsync |   504.3 ms | 2.99 ms | 2.79 ms |   7.44 KB |

## DependencyInjection

| Method                      | Mean     | Error    | StdDev   | Gen0   | Allocated |
|---------------------------- |---------:|---------:|---------:|-------:|----------:|
| UsingDependencyInjection    | 26.26 ns | 0.136 ns | 0.121 ns |      - |         - |
| NotUsingDependencyInjection | 30.36 ns | 0.434 ns | 0.385 ns | 0.0014 |      24 B |