namespace Bencher.Functions;

internal static class ControlFlowFunctions
{
    public static string MethodWithIfAndElse(string condition)
    {
        if (condition == "1")
        {
            return condition;
        }
        else if (condition == "2")
        {
            return condition;
        }
        else if (condition == "3")
        {
            return condition;
        }
        else if (condition == "4")
        {
            return condition;
        }
        else if (condition == "5")
        {
            return condition;
        }
        else if (condition == "6")
        {
            return condition;
        }
        else if (condition == "7")
        {
            return condition;
        }
        else if (condition == "8")
        {
            return condition;
        }
        else if (condition == "9")
        {
            return condition;
        }
        else
        {
            return condition;
        }
    }

    public static string MethodWithSwitch(string condition)
    {
        switch (condition)
        {
            case "1":
                return condition;
            case "2":
                return condition;
            case "3":
                return condition;
            case "4":
                return condition;
            case "5":
                return condition;
            case "6":
                return condition;
            case "7":
                return condition;
            case "8":
                return condition;
            case "9":
                return condition;
            default:
                return condition;
        }
    }

    public static string MethodWithSwitchExpression(string condition)
    {
        return condition switch
        {
            "1" => condition,
            "2" => condition,
            "3" => condition,
            "4" => condition,
            "5" => condition,
            "6" => condition,
            "7" => condition,
            "8" => condition,
            "9" => condition,
            _ => condition,
        };
    }
}
