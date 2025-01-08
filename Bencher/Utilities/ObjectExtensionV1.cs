using Newtonsoft.Json;

namespace Bencher.Utilities;

public static class ObjectExtensionV1
{
    public static void ObjectFlatterV1(this object currentObject, out Dictionary<string, string> objectsKeyValuePairs)
    {
        objectsKeyValuePairs = [];
        foreach (var item in currentObject.GetType().GetProperties())
        {
            objectsKeyValuePairs[item.Name] = JsonConvert.SerializeObject(item.GetValue(currentObject));
        }
    }

    public static void GetObjectDiffV1(this object updatedObject, Dictionary<string, string> currentObjectsKeyValuePairs, out string diff)
    {
        Dictionary<string, Dictionary<string, object>> temp = [];

        try
        {
            updatedObject.ObjectFlatterV1(out Dictionary<string, string> updatedObjectsKeyValuePairs);

            foreach (var item in currentObjectsKeyValuePairs)
            {
                var curentValue = item.Value;
                var updatedValue = updatedObjectsKeyValuePairs[item.Key];
                if (curentValue != updatedValue)
                {
                    temp[item.Key] = new Dictionary<string, object>
                    {
                        { "old", curentValue },
                        { "updated", updatedValue }
                    };
                }
            }
        }
        catch (Exception)
        {

        }
        finally
        {
            diff = JsonConvert.SerializeObject(temp);
            temp.Clear();
        }
    }
}
