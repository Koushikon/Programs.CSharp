using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

using Fast_RegExpr.Model;

namespace Fast_RegExpr;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class BenchmarkMeasure
{
    private const string _email = "asman@galaxy.com";

    [Benchmark(Baseline = true)]
    public void ContainsWord_1()
    {
        RegexMatch.ContainsWord_1(_email);
    }


    [Benchmark]
    public void ContainsWord_2()
    {
        RegexMatch.ContainsWord_2(_email);
    }


    [Benchmark]
    public void ContainsWord_3()
    {
        RegexMatch.ContainsWord_3(_email);
    }
}