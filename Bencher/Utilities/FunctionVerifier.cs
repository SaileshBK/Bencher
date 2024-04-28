using Bencher.Dummy.Classes;
using Bencher.Functions;
using Bencher.Utilities.Enums;

namespace Bencher.Utilities
{
    internal static class FunctionVerifier
    {
        public static void Verify(Function function)
        {
            switch (function)
            {
                case Function.MethodParameters:
                    FunctionParameter();
                    break;
                default:
                    Console.WriteLine("Not Implemented");
                    break;
            }   

        }

        private static void FunctionParameter()
        {
            var test = new TestRefClass
            {
                FinalValue = "Not Modified"
            };

            // Without ref the re-assignment of object will not modify original
            MethodParameters.MethodWithoutRef(test);
            Console.WriteLine($"Using Method: {test.FinalValue}");

            // With ref the re-assignment of object will modify original 
            MethodParameters.MethodWithRef(ref test);
            Console.WriteLine($"Using Method: {test.FinalValue}");
        }
    }
}
