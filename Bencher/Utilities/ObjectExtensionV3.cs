using System.Text.Json;
using Bencher.Utilities.Enums;
using MongoDB.Bson;

namespace Bencher.Utilities;

public static class ObjectExtensionV3
{
    public static void ObjectFlatterV3(this BsonDocument currentObject, out Dictionary<string, string> objectsKeyValuePairs)
    {
        objectsKeyValuePairs = [];
        foreach (var item in currentObject)
        {
            objectsKeyValuePairs[item.Name] = item.Value.ToString()!;
        }
    }

    public static void GetObjectDiffV3(this BsonDocument updatedObject, Dictionary<string, string> currentObjectsKeyValuePairs, out string diff)
    {
        Dictionary<string, Dictionary<string, string>> temp = [];

        try
        {
            updatedObject.ObjectFlatterV3(out Dictionary<string, string> updatedObjectsKeyValuePairs);

            foreach (var item in currentObjectsKeyValuePairs)
            {
                var updatedValue = updatedObjectsKeyValuePairs[item.Key];
                if (!updatedObjectsKeyValuePairs.TryGetValue(item.Key, out var curentValue) || curentValue == updatedValue)
                {
                    continue;
                }

                temp[item.Key] = new Dictionary<string, string>
                {
                    { nameof(ObjectState.Old), curentValue },
                    { nameof(ObjectState.Updated), updatedValue }
                };
            }
        }
        catch (Exception ex)
        {

        }
        finally
        {
            diff = JsonSerializer.Serialize(temp);
            temp.Clear();
        }
    }
}
