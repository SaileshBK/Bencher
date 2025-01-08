using Bencher.Functions;
using Bencher.Utilities.Enums;
using BenchmarkDotNet.Attributes;

namespace Bencher.Benchmark;

[MemoryDiagnoser]
public class EnumToStringBenchmark
{
    [Benchmark]
    public string UsingSimpleEnumToString()
    {
        return EnumToString.SimpleToString(ExampleEnums.Enum1);
    }

    [Benchmark]
    public string UsingFullyMappedNameOfEnum()
    {
        return EnumToString.MappedNameOfEnum(ExampleEnums.Enum1);
    }

    [Benchmark]
    public string UsingNameOfEnum()
    {
        return EnumToString.NameOfEnum(ExampleEnums.Enum1);
    }

    [Benchmark]
    public string UsingGetName()
    {
        return EnumToString.GetName(ExampleEnums.Enum1);
    }
}
