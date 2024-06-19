using System.Reflection;
using BenchmarkDotNet.Running;

namespace Bencher.Utilities;

internal class MethodInvoker
{
    public static void Invoke(string methodToInvoke)
    {
        // Get the Type from the class name
        Type methodToInvokeType = Type.GetType(methodToInvoke)!;

        if (methodToInvokeType is null)
        {
            Console.WriteLine($"Class {methodToInvokeType} not found.");
            return;
        }

        // Get the method info for the generic RunBenchmark<T> method
        MethodInfo method = typeof(MethodInvoker).GetMethod(nameof(RunBenchmark))!;
        if (method is null)
        {
            Console.WriteLine("RunBenchmark method not found.");
            return;
        }

        // Make the method generic with the specified type and invoke it.
        MethodInfo genericMethod = method.MakeGenericMethod(methodToInvokeType);
        genericMethod.Invoke(null, null);
    }
    public static void RunBenchmark<T>() where T : class
    {
        BenchmarkRunner.Run<T>();
    }
}
