// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using DotNetPerf;


////// BenchMarking
// BenchmarkRunner.Run<LargeFileRead>();
// BenchmarkRunner.Run<BoxingUnboxing>();
// BenchmarkRunner.Run<ArrayVsArrayList>();


//// VS Performance Profiler
//PerfTest test = new PerfTest();
//test.RunCpuHeavyTask();
//test.RunMemoryHeavyTask();

var tracing = new TracingDemo();
tracing.StartWork();