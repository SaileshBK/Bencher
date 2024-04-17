# Summary
BenchmarkDotNet v0.13.12, Windows 10
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK 7.0.100
  [Host]     : .NET 7.0.16 (7.0.1624.6629), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

## SubstringVsTake



| Method              | Mean     | Error    | StdDev   | Gen0   | Allocated |
|-------------------- |---------:|---------:|---------:|-------:|----------:|
| MethodWithTake      | 49.19 ns | 0.129 ns | 0.121 ns | 0.0167 |     280 B |
| MethodWithSubstring | 31.50 ns | 0.476 ns | 0.445 ns | 0.0086 |     144 B |