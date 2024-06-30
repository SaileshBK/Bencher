using Bencher.Utilities.Menu;
using BenchmarkDotNet.Running;

namespace Bencher;

internal class Program
{
    /*
     * To run the Bencher Simply set Bencher as Startup project and run.
     * Note: Run it on Release mode.
     */
    private static void Main(string[] args)
    {
        MainMenu.ShowMenu();

        // Test Function Outputs
        //FunctionVerifier.Verify(Function.MethodParameters);
    }

    public static void RunBenchmark<T>() where T : class
    {
        BenchmarkRunner.Run<T>();
    }
}