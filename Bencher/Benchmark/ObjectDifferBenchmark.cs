using Bencher.Dummy.Classes;
using Bencher.Functions;
using BenchmarkDotNet.Attributes;

namespace Bencher.Benchmark;

[MemoryDiagnoser]
public class ObjectDifferBenchmark
{
    private static ExamplePayload _examplePayload1 = new();
    private static ExamplePayload _examplePayload2 = new();
    [GlobalSetup]
    public void Setup()
    {
        _examplePayload1 = new()
        {
            Property1 = true,
            Property2 = "test",
            Property3 =
             [
                 new()
                {
                    PayloadType = false
                }
             ]
        };

        _examplePayload2 = new()
        {
            Property1 = false,
            Property2 = "test",
            Property3 =
            [
                new()
                {
                    PayloadType = true
                }
            ]
        };

    }

    [Benchmark]
    public string UsingObjectDifferV1()
    {
        return ObjectDiffer.RandomMethodV1(_examplePayload1, _examplePayload2);
    }

    [Benchmark]
    public string UsingObjectDifferV2()
    {
        return ObjectDiffer.RandomMethodV2(_examplePayload1, _examplePayload2);
    }
}
