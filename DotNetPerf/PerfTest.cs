using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPerf
{
    public class PerfTest
    {
        public void RunCpuHeavyTask()
        {
            for (int i = 0; i < 10_000_000; i++)
            {
                double val = Math.Sqrt(i); // heavy CPU work
            }
        }

        public void RunMemoryHeavyTask()
        {
            List<string> data = new List<string>();
            for (int i = 0; i < 100000; i++)
            {
                data.Add(Guid.NewGuid().ToString()); // memory allocation
            }
        }
    }
}
