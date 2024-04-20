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
            ControlFlowFunctions.MethodWithIfAndElse(Constants.TestString);
        }

        [Benchmark]
        public void MethodWithSwitch()
        {
            ControlFlowFunctions.MethodWithSwitch(Constants.TestString);
        }

        [Benchmark]
        public void MethodWithSwitchExpression()
        {
            ControlFlowFunctions.MethodWithSwitchExpression(Constants.TestString);
        }
    }
}
