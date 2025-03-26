using BenchmarkDotNet.Attributes;

namespace DotNetPerf
{
    [MemoryDiagnoser]
    public class LargeFileRead
    {
        private const string FilePath = "largefile.txt";

        [Benchmark]
        public string SyncFileRead()
        {
            return File.ReadAllText(FilePath);
        }

        [Benchmark]
        public async Task<string> AsyncFileRead()
        {
            return await File.ReadAllTextAsync(FilePath);
        }
    }
}
