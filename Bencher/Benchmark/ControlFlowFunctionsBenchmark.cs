using Bencher.Functions;
using Bencher.Utilities;
using BenchmarkDotNet.Attributes;

namespace Bencher.Benchmark
{
    [MemoryDiagnoser]
    public class ControlFlowFunctionsBenchmark
    {
        [Benchmark]
        public void MethodWithIfAndElse()
        {
            ControlFlowFunctions.MethodWithIfAndElse(StringValues.TestString);
        }

        [Benchmark]
        public void MethodWithSwitch()
        {
            ControlFlowFunctions.MethodWithSwitch(StringValues.TestString);
        }

        [Benchmark]
        public void MethodWithSwitchExpression()
        {
            ControlFlowFunctions.MethodWithSwitchExpression(StringValues.TestString);
        }
    }
}
