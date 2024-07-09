```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.302
  [Host]     : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2


```
| Method | Mean     | Error    | StdDev   |
|------- |---------:|---------:|---------:|
| Sha256 | 42.53 μs | 0.831 μs | 1.020 μs |
| Md5    | 40.75 μs | 0.764 μs | 0.677 μs |
