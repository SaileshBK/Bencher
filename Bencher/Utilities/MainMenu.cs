using BenchmarkDotNet.Attributes;
using Spectre.Console;
using System.Reflection;

namespace Bencher.Utilities;

internal static class MainMenu
{
    private static readonly Dictionary<string, string> _currentBenchmarkTypes = new();
    public static void ShowMenu()
    {
        var benchmarkTypes = Assembly.GetExecutingAssembly().GetTypes()
           .Where(t => t.GetCustomAttributes(typeof(MemoryDiagnoserAttribute), false).Length > 0);

        foreach (var benchmarkType in benchmarkTypes)
        {
            _currentBenchmarkTypes.TryAdd(benchmarkType.Name, benchmarkType.FullName!);
        }

        // Ask for the user's input
        var benchmarkChoice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("[green]Please Select the benchmark you want to run:[/]")
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to reveal more benchmarks)[/]")
                .AddChoices(_currentBenchmarkTypes.Keys));

        AnsiConsole.WriteLine($"Running {benchmarkChoice}...");

        if (!_currentBenchmarkTypes.TryGetValue(benchmarkChoice, out var methodToInvoke))
        {
            AnsiConsole.WriteLine($"Could not find {benchmarkChoice}...");
        }

        MethodInvoker.Invoke(methodToInvoke!);
    }
}
