using Bencher.Dummy.Classes;
using Bencher.Functions;
using Bencher.Utilities;
using BenchmarkDotNet.Attributes;

namespace Bencher.Benchmark
{
    [MemoryDiagnoser]
    public class ControlFlowWithGenericFunctionsBenchmark
    {
        [Benchmark]
        public void MethodWithIfAndElse()
        {
            for (var i = 0; i < 10; i++)
            {
                ControlFlowWithGenericFunctions.MethodWithIfAndElse<Test8>(Constants.TestString);
            }
        }

        [Benchmark]
        public void MethodWithSwitch()
        {
            for (var i = 0; i < 10; i++)
            {
                ControlFlowWithGenericFunctions.MethodWithSwitch<Test8>(Constants.TestString);
            }
        }

        [Benchmark]
        public void MethodWithSwitchExpression()
        {
            for (var i = 0; i < 10; i++)
            {
                ControlFlowWithGenericFunctions.MethodWithSwitchExpression<Test8>(Constants.TestString);
            }
        }
    }
}
