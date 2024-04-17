﻿using BenchmarkDotNet.Attributes;

namespace Experiment.Benchmark.Methods
{
    [MemoryDiagnoser]
    public class StringTest
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

        [Benchmark]
        public string MethodWithSlice()
        {
            ReadOnlySpan<char> inputValue = _inputValue;
            if (inputValue.LastIndexOf("'") != -1)
            {
                return inputValue.Slice(0, inputValue.Length - 1).ToString() + " value";
            }

            return _inputValue;
        }
    }
}