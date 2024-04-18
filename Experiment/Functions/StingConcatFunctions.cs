namespace Experiment.Functions;

public static class StingConcatFunctions
{
    public static string MethodWithTake(string input)
    {
        char[] inputValueChar = input.ToCharArray();
        if (inputValueChar.Last().ToString() == "'")
        {
            var spit = inputValueChar.Take(inputValueChar.Length - 1);
            return spit + " value";
        }

        return input;
    }

    public static string MethodWithSubstring(string input)
    {
        if (input.EndsWith("'"))
        {
            return $"{input.Substring(0, input.Length - 1)} value";
        }

        return input;
    }

    public static string MethodWithSlice(string input)
    {
        ReadOnlySpan<char> inputValue = input;
        var lastIndexOfQuote = inputValue.LastIndexOf('\'');
        if (lastIndexOfQuote != -1)
        {
            return inputValue.Slice(0, lastIndexOfQuote).ToString() + " value";
        }

        return input;
    }

    public static string MethodWithRange(string input)
    {
        ReadOnlySpan<char> inputValue = input;
        var lastIndexOfQuote = inputValue.LastIndexOf('\'');
        if (lastIndexOfQuote != -1)
        {
            return inputValue[..lastIndexOfQuote].ToString() + " value";
        }

        return input;
    }
}
