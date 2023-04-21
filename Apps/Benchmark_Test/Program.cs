using BenchmarkDotNet.Running;

/**
 * * Source: https://www.youtube.com/watch?v=EWmufbVF2A4
 * * Official Repo: https://github.com/dotnet/BenchmarkDotNet
 * ? Docs: https://benchmarkdotnet.org/
 */

namespace Benchmark_Test;

internal class Program
{
    static void Main()
    {
        BenchmarkRunner.Run<DateParserBenchmark>();
    }
}