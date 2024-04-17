# Summary
BenchmarkDotNet v0.13.12, Windows 10
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK 7.0.100
  [Host]     : .NET 7.0.16 (7.0.1624.6629), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

## StringTest



| Method              | Mean     | Error    | StdDev   | Gen0   | Allocated |
|-------------------- |---------:|---------:|---------:|-------:|----------:|
| MethodWithTake      | 51.49 ns | 0.726 ns | 0.679 ns | 0.0167 |     280 B |
| MethodWithSubstring | 33.01 ns | 0.695 ns | 1.198 ns | 0.0086 |     144 B |
| MethodWithSlice     | 19.95 ns | 0.279 ns | 0.233 ns | 0.0086 |     144 B |