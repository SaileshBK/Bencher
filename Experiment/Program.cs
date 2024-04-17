using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Experiment
{
    public static class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchTest>();
        }

    }
}

[MemoryDiagnoser]
public class BenchTest
{

    private static readonly string _inputValue = "This is a test string'";

    [Benchmark]
    public string Method1()
    {
        char[] inputValueChar = _inputValue.ToCharArray();
        if (inputValueChar.Last().ToString() == "'")
        {
            var spit = inputValueChar.Take(inputValueChar.Length - 1);
            return spit + " value";
        }

        return _inputValue;
    }

    [Benchmark]
    public string Method2()
    {
        if (_inputValue.EndsWith("'"))
        {
            return $"{_inputValue.Substring(0, _inputValue.Length - 1)} value";
        }

        return _inputValue;
    }
}
