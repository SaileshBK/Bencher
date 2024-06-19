using Bencher.Utilities;
using Bencher.Utilities.Enums;

namespace Bencher.Functions;

public static class EnumToString
{
    public static string SimpleToString(ExampleEnums exampleEnums)
    {
        return exampleEnums.ToString();
    }

    public static string MappedNameOfEnum(ExampleEnums exampleEnums)
    {
        return exampleEnums.EnumString();
    }

    public static string NameOfEnum(ExampleEnums exampleEnums) => nameof(exampleEnums);
}
