using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPerf
{
    public class TracingDemo
    {
        public void StartWork()
        {
            Console.WriteLine("App started. Doing work...");
            for (int i = 0; i < 100; i++)
            {
                Work(i);
                Thread.Sleep(500);
            }

            Console.WriteLine("Finished. Press any key to exit.");
            Console.ReadKey();
        }

        private void Work(int i)
        {
            double result = 0;
            for (int j = 0; j < 1_000_000; j++)
            {
                result += Math.Sqrt(j + i);
            }
            Console.WriteLine($"Completed iteration {i}");
        }
    }
}
