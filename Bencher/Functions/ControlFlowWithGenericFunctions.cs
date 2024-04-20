using Bencher.Dummy.Classes;

namespace Bencher.Functions;

internal static class ControlFlowWithGenericFunctions
{
    public static string MethodWithIfAndElse<T>(string condition) where T : class
    {
        if (typeof(T) == typeof(Test1))
        {
            return condition;
        }
        else if (typeof(T) == typeof(Test2))
        {
            return condition;
        }
        else if (typeof(T) == typeof(Test6))
        {
            return condition;
        }
        else if (typeof(T) == typeof(Test3))
        {
            return condition;
        }
        else if (typeof(T) == typeof(Test5))
        {
            return condition;
        }
        else if (typeof(T) == typeof(Test4))
        {
            return condition;
        }
        else if (typeof(T) == typeof(Test7))
        {
            return condition;
        }
        else if (typeof(T) == typeof(Test9))
        {
            return condition;
        }
        else if (typeof(T) == typeof(Test8))
        {
            return condition;
        }
        else
        {
            return condition;
        }
    }

    public static string MethodWithSwitch<T>(string condition) where T: class
    {
        switch (typeof(T))
        {
            case Type t when t == typeof(Test1):
                return condition;
            case Type t when t == typeof(Test3):
                return condition;
            case Type t when t == typeof(Test2):
                return condition;
            case Type t when t == typeof(Test5):
                return condition;
            case Type t when t == typeof(Test4):
                return condition;
            case Type t when t == typeof(Test6):
                return condition;
            case Type t when t == typeof(Test9):
                return condition;
            case Type t when t == typeof(Test8):
                return condition;
            case Type t when t == typeof(Test7):
                return condition;
            default:
                return condition;
        }
    }

    public static string MethodWithSwitchExpression<T>(string condition) where T : class
    {
        return typeof(T) switch
        {
            Type t when t == typeof(Test1) => condition,
            Type t when t == typeof(Test3) => condition,
            Type t when t == typeof(Test2) => condition,
            Type t when t == typeof(Test5) => condition,
            Type t when t == typeof(Test4) => condition,
            Type t when t == typeof(Test6) => condition,
            Type t when t == typeof(Test9) => condition,
            Type t when t == typeof(Test8) => condition,
            Type t when t == typeof(Test7) => condition,
            _ => condition
        };
    }
}
