using Bencher.Dummy.Classes;
using Bencher.Utilities;
using MongoDB.Bson;

namespace Bencher.Functions;

public static class ObjectDiffer
{
    public static string RandomMethodV1(ExamplePayload examplePayload1, ExamplePayload examplePayload2)
    {

        examplePayload1.ObjectFlatterV1(out Dictionary<string, string> object1KeyValuePairs);
        examplePayload2.GetObjectDiffV1(object1KeyValuePairs, out string diff);
        return diff;
    }

    public static string RandomMethodV2(ExamplePayload examplePayload1, ExamplePayload examplePayload2)
    {

        examplePayload1.ObjectFlatterV2(out Dictionary<string, string> object1KeyValuePairs);
        examplePayload2.GetObjectDiffV2(object1KeyValuePairs, out string diff);
        return diff;
    }

    public static string RandomMethodV3(BsonDocument examplePayload1, BsonDocument examplePayload2)
    {

        examplePayload1.ObjectFlatterV3(out Dictionary<string, string> object1KeyValuePairs);
        examplePayload2.GetObjectDiffV3(object1KeyValuePairs, out string diff);
        return diff;
    }
}
