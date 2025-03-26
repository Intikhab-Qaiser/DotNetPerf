using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPerf
{
    [MemoryDiagnoser]
    public class StringvsStringBuilder
    {
        // Bad
        [Benchmark]
        public void ProcessString()
        {
            for (int i = 0; i < 1_000_000; i++)
            {
                string s = "item" + i.ToString(); // allocates new string each time
            }
        }

        // Good
        [Benchmark]
        public void ProcessStringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 1_000_000; i++)
            {
                sb.Append("item").Append(i);
            }
        }
    }
}
