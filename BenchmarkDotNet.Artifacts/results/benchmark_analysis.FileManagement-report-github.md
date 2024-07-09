```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.302
  [Host]     : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2


```
| Method | Mean    | Error   | StdDev  | Median  | Gen0         | Gen1        | Gen2       | Allocated |
|------- |--------:|--------:|--------:|--------:|-------------:|------------:|-----------:|----------:|
| Run1   | 9.840 s | 1.029 s | 2.985 s | 8.303 s | 1515000.0000 | 162000.0000 | 12000.0000 |   7.13 GB |
