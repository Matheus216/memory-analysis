
using benchmark_analysis;
using BenchmarkDotNet.Running;

Console.WriteLine("Hello, Bench!");

var summary = BenchmarkRunner.Run<FileManagement>(); 

Console.WriteLine("Finished!");