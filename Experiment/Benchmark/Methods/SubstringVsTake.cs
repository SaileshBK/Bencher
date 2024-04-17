using BenchmarkDotNet.Attributes;

namespace Experiment.Benchmark.Methods
{
    [MemoryDiagnoser]
    public class SubstringVsTake
    {
        private static readonly string _inputValue = "This is a test string'";

        [Benchmark]
        public string MethodWithTake()
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
        public string MethodWithSubstring()
        {
            if (_inputValue.EndsWith("'"))
            {
                return $"{_inputValue.Substring(0, _inputValue.Length - 1)} value";
            }

            return _inputValue;
        }
    }
}
