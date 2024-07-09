using System.Diagnostics;

namespace benchmark_analysis;


public static class BenchmarkAnalysis
{
    public static void Benchmark(Action action, int interations) 
    {
        GC.Collect();
        action.Invoke();
        Stopwatch sw = Stopwatch.StartNew();

        var info = GC.GetGCMemoryInfo();
        for (int i = 0; i < interations; i++)
        {
            action.Invoke();
        }
        sw.Stop();
        Console.WriteLine($"{sw.ElapsedMilliseconds / interations} ms");
    }
}