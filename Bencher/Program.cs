﻿using Bencher.Utilities.Menu;

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
}