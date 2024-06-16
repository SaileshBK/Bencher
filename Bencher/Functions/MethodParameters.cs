using Bencher.Dummy.Classes;

namespace Bencher.Functions
{
    internal static class MethodParameters
    {
        public static void MethodWithoutRef(TestRefClass incomingValue)
        {
            incomingValue.FinalValue = "Modified";
            incomingValue = new TestRefClass();
        }

        public static void MethodWithRef(ref TestRefClass incomingValue)
        {
            incomingValue.FinalValue = "Modified";
            incomingValue = new TestRefClass();
        }
    }
}