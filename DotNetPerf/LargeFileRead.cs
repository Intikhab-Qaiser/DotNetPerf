using BenchmarkDotNet.Attributes;

namespace DotNetPerf
{
    [MemoryDiagnoser]
    public class LargeFileRead
    {
        private const string FilePath = "largefile.txt";

        // Bad
        [Benchmark]
        public string SyncFileRead()
        {
            return File.ReadAllText(FilePath);
        }
        // Good
        [Benchmark]
        public async Task<string> AsyncFileRead()
        {
            return await File.ReadAllTextAsync(FilePath);
        }

        // Bad
        public void ReadFile()
        {
            var reader = new StreamReader("file.txt");
            var content = reader.ReadToEnd();
        }
        // Good
        public void ReadFileDisponse()
        {
            using var reader = new StreamReader("file.txt");
            var content = reader.ReadToEnd();
        }

    }
}
