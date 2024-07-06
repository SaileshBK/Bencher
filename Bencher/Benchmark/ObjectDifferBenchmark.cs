using Bencher.Dummy.Classes;
using Bencher.Functions;
using BenchmarkDotNet.Attributes;
using MongoDB.Bson;

namespace Bencher.Benchmark;

[MemoryDiagnoser]
public class ObjectDifferBenchmark
{
    private static ExamplePayload _examplePayload1;
    private static ExamplePayload _examplePayload2;
    
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
            Property2 = "not test",
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

    [Benchmark]
    public string UsingObjectDifferV3()
    {
        return ObjectDiffer.RandomMethodV3(_examplePayload1.ToBsonDocument(), _examplePayload2.ToBsonDocument());
    }
}
