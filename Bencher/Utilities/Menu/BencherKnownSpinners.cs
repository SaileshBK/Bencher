using Spectre.Console;

namespace Bencher.Utilities.Menu;

public static class BencherKnownSpinners
{
    public static Spinner StartingSpinner { get; } = new BencherStartingSpinner();
}
