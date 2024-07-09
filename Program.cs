
using System.Diagnostics;
using benchmark_analysis;
using BenchmarkDotNet.Running;

var service = new FileManagement();

var before0 = GC.CollectionCount(0);
var before1 = GC.CollectionCount(1);
var before2 = GC.CollectionCount(2);

var sw = new Stopwatch();

sw.Start();

service.RunRating2();

sw.Stop();

Console.WriteLine($"{sw.ElapsedMilliseconds} ms");
Console.WriteLine($"Gen0: {GC.CollectionCount(0) - before0}");
Console.WriteLine($"Gen1: {GC.CollectionCount(1) - before1}");
Console.WriteLine($"Gen2: {GC.CollectionCount(2) - before2}");
Console.WriteLine($"Memory: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024} mb");