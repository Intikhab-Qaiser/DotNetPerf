using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPerf
{
    [MemoryDiagnoser]
    public class BoxingUnboxing
    {
        private object _boxedValue;

        [Benchmark]
        public void WithBoxing()
        {
            int val = 42;
            _boxedValue = val;           // Boxing
            int unboxed = (int)_boxedValue; // Unboxing
        }

        [Benchmark]
        public void WithoutBoxing()
        {
            int val = 42;
            int result = val; // No boxing/unboxing
        }
    }
}
