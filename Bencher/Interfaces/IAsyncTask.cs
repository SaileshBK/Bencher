namespace Bencher.Interfaces
{
    public interface IAsyncTask
    {
        Task<string> ExampleHalfSecondAsync(string data);
        Task<string> ExampleOneSecondAsync(string data);
    }
}