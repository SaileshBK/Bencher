using Bencher.Interfaces;

namespace Bencher.Functions
{
    internal class AsyncTask : IAsyncTask
    {
        public async Task<string> ExampleOneSecondAsync(string data)
        {
            await Task.Delay(1000);
            return data;
        }

        public async Task<string> ExampleHalfSecondAsync(string data)
        {
            await Task.Delay(500);
            return data;
        }
    }
}
