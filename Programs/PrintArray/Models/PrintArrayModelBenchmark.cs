using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace PrintArray.Models;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class PrintArrayModelBenchmark
{
    public int[] Numbers { get; set; }
    public PrintArrayModel _printArray = new PrintArrayModel();

    public PrintArrayModelBenchmark()
    {
        Numbers = FillElements(200);
    }

    // Fill the elements to array
    public int[] FillElements(int length)
    {
        int[] nums = new int[length];

        for (int i = 0; i < length; i++)
        {
            var number = new Random().Next(1, 1000);
            nums[i] = number;
        }

        return nums;
    }


    [Benchmark(Baseline = true)]
    public void ForLoop()
    {
        _printArray.ForLoop(Numbers);
    }


    [Benchmark]
    public void ForeachLoop()
    {
        _printArray.ForeachLoop(Numbers);
    }


    [Benchmark]
    public void ToListForEach()
    {
        _printArray.ToListForEach(Numbers);
    }


    [Benchmark]
    public void WithStringJoin()
    {
        _printArray.WithStringJoin(Numbers);
    }


    [Benchmark]
    public void WithStaticArrayClass()
    {
        _printArray.WithStaticArrayClass(Numbers);
    }


    [Benchmark]
    public void WithAsSpan()
    {
        _printArray.WithAsSpan(Numbers);
    }
}
