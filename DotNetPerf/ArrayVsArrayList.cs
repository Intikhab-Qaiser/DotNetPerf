using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPerf
{
    [MemoryDiagnoser]
    public class ArrayVsArrayList
    {
        private const int Count = 10000;

        [Benchmark]
        public void UsingArrayList()
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < Count; i++)
                list.Add(i); // boxing

            int sum = 0;
            for (int i = 0; i < Count; i++)
                sum += (int)list[i]; // unboxing
        }

        [Benchmark]
        public void UsingIntArray()
        {
            int[] array = new int[Count];
            for (int i = 0; i < Count; i++)
                array[i] = i;

            int sum = 0;
            for (int i = 0; i < Count; i++)
                sum += array[i];
        }
    }
}
