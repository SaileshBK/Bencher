using Bencher.Utilities.Menu;

namespace Bencher;

internal sealed class Program
{
    /*
     * To run the Bencher Simply set as Startup project and run.
     * Note: Run it on Release mode.
     */
    private static void Main(string[] args)
    {
        MainMenu.ShowMenu();
    }
}