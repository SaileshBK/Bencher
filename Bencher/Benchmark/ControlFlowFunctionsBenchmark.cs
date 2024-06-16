using Bencher.Functions;
using Bencher.Utilities;
using BenchmarkDotNet.Attributes;

namespace Bencher.Benchmark
{
    [MemoryDiagnoser]
    public class ControlFlowFunctionsBenchmark
    {
        [Benchmark]
        public void UsingIfAndElse()
        {
            ControlFlowFunctions.MethodWithIfAndElse(Constants.TestString);
        }

        [Benchmark]
        public void UsingSwitch()
        {
            ControlFlowFunctions.MethodWithSwitch(Constants.TestString);
        }

        [Benchmark]
        public void UsingSwitchExpression()
        {
            ControlFlowFunctions.MethodWithSwitchExpression(Constants.TestString);
        }
    }
}