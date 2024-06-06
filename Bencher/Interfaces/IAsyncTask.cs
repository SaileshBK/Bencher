namespace Bencher.Interfaces
{
    internal interface IAsyncTask
    {
        Task<string> ExampleHalfSecondAsync(string data);
        Task<string> ExampleOneSecondAsync(string data);
    }
}