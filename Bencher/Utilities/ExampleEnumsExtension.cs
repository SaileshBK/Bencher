using Bencher.Utilities.Enums;

namespace Bencher.Utilities;

public static class ExampleEnumsExtension
{
    public static string EnumString(this ExampleEnums exampleEnums)
    {
        return exampleEnums switch
        {
            ExampleEnums.Enum1 => nameof(ExampleEnums.Enum1),
            ExampleEnums.Enum2 => nameof(ExampleEnums.Enum2),
            ExampleEnums.Enum3 => nameof(ExampleEnums.Enum3),
            ExampleEnums.Enum4 => nameof(ExampleEnums.Enum4),
            ExampleEnums.Enum5 => nameof(ExampleEnums.Enum5),
            ExampleEnums.Enum6 => nameof(ExampleEnums.Enum6),
            _ => throw new ArgumentOutOfRangeException(nameof(exampleEnums)),
        };
    }
}
