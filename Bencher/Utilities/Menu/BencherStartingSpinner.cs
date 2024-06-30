using Spectre.Console;

namespace Bencher.Utilities.Menu;

public sealed class BencherStartingSpinner : Spinner
{
    public override TimeSpan Interval => TimeSpan.FromMilliseconds(250);
    public override bool IsUnicode => false;
    public override IReadOnlyList<string> Frames => 
        ["▐STARTING________▌",
         "▐STARTING_B______▌",
         "▐STARTING_BE_____▌",
         "▐STARTING_BEN____▌",
         "▐STARTING_BENC___▌",
         "▐STARTING_BENCH__▌",
         "▐STARTING_BENCHE_▌",
         "▐STARTING_BENCHER▌"];
}
