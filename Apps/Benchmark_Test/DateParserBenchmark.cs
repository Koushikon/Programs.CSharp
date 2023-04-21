using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmark_Test;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class DateParserBenchmark
{
    private const string _dateTime = "2023-04-17T23:51:02Z";
    private static readonly DateParser _dateParser = new DateParser();

    [Benchmark(Baseline = true)]
    public void GetYearFromDT()
    {
        _dateParser.GetYearFromDT(_dateTime);
    }


    [Benchmark]
    public void GetYearFromSplit()
    {
        _dateParser.GetYearFromSplit(_dateTime);
    }


    [Benchmark]
    public void GetYearFromSubString()
    {
        _dateParser.GetYearFromSubString(_dateTime);
    }


    [Benchmark]
    public void GetYearFromSpan()
    {
        _dateParser.GetYearFromSpan(_dateTime);
    }


    [Benchmark]
    public void GetYearFromSpanManualConvertion()
    {
        _dateParser.GetYearFromSpanManualConvertion(_dateTime);
    }
}
