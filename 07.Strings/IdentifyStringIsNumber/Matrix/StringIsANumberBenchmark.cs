using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Matrix;


[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[MemoryDiagnoser]
public class StringIsANumberBenchmark
{
	private string value = "123456789";

	[Benchmark]
	public void IntTryParse()
	{
		StringIsANumber.IntTryParse(value);
	}

	[Benchmark]
	public void DoubleTryParse()
	{
		StringIsANumber.DoubleTryParse(value);
	}

	[Benchmark]
	public void UsingRegex()
	{
		StringIsANumber.UsingRegex(value);
	}

	[Benchmark]
	public void UsingCompiledRegex()
	{
		StringIsANumber.UsingCompiledRegex(value);
	}

	[Benchmark]
	public void UsingCharIsDigit()
	{
		StringIsANumber.UsingCharIsDigit(value);
	}

	[Benchmark]
	public void UsingCharIsDigitWithForEach()
	{
		StringIsANumber.UsingCharIsDigitWithForEach(value);
	}

	[Benchmark]
	public void UsingCharIsBetween09()
	{
		StringIsANumber.UsingCharIsBetween09(value);
	}
}