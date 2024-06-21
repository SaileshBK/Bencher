using System.Text.Json;

namespace Bencher.Utilities
{
    public static class ObjectExtensionV2
    {
        public static void ObjectFlatterV2(this object currentObject, out Dictionary<string, string> objectsKeyValuePairs)
        {
            objectsKeyValuePairs = [];
            foreach (var item in currentObject.GetType().GetProperties())
            {
                objectsKeyValuePairs[item.Name] = JsonSerializer.Serialize(item.GetValue(currentObject));
            }
        }

        public static void GetObjectDiffV2(this object updatedObject, Dictionary<string, string> currentObjectsKeyValuePairs, out string diff)
        {
            Dictionary<string, Dictionary<string, object>> temp = [];

            try
            {
                updatedObject.ObjectFlatterV2(out Dictionary<string, string> updatedObjectsKeyValuePairs);

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
}
