# Summary
BenchmarkDotNet v0.13.12, Windows 10
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK 7.0.100
  [Host]     : .NET 7.0.16 (7.0.1624.6629), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

## StringTest



| Method              | Mean     | Error    | StdDev   | Gen0   | Allocated |
|-------------------- |---------:|---------:|---------:|-------:|----------:|
| MethodWithTake      | 52.72 ns | 1.083 ns | 1.330 ns | 0.0167 |     280 B |
| MethodWithSubstring | 32.91 ns | 0.581 ns | 0.485 ns | 0.0086 |     144 B |
| MethodWithSlice     | 19.42 ns | 0.313 ns | 0.293 ns | 0.0086 |     144 B |
| MethodWithRange     | 20.34 ns | 0.302 ns | 0.268 ns | 0.0086 |     144 B |