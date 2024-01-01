using BenchmarkDotNet.Running;

namespace Matrix;

public class Program
{
	static void Main()
	{
		//CallStringIsANumber();

		BenchmarkRunner.Run<StringIsANumberBenchmark>();
	}

	public static void CallStringIsANumber()
	{
		var values = new string[] { "1234", "ABC-789", "1.23", "9999999999" };

		Console.WriteLine("Using int.TryParse();");
		foreach (var item in values)
		{
			Console.WriteLine($" * {item,-15} ===> {StringIsANumber.IntTryParse(item)}");
		}
		Console.WriteLine("- - -\n");


		Console.WriteLine("Using double.TryParse();");
		foreach (var item in values)
		{
			Console.WriteLine($" * {item,-15} ===> {StringIsANumber.DoubleTryParse(item)}");
		}
		Console.WriteLine("- - -\n");


		Console.WriteLine("Using Regex:");
		foreach (var item in values)
		{
			Console.WriteLine($" * {item,-15} ===> {StringIsANumber.UsingRegex(item)}");
		}
		Console.WriteLine("- - -\n");


		Console.WriteLine("Using Compiled Regex:");
		foreach (var item in values)
		{
			Console.WriteLine($" * {item,-15} ===> {StringIsANumber.UsingCompiledRegex(item)}");
		}
		Console.WriteLine("- - -\n");


		Console.WriteLine("Using Char.IsDigit:");
		foreach (var item in values)
		{
			Console.WriteLine($" * {item,-15} ===> {StringIsANumber.UsingCharIsDigit(item)}");
		}
		Console.WriteLine("- - -\n");


		Console.WriteLine("Using char.IsAsciiDigit:");
		foreach (var item in values)
		{
			Console.WriteLine($" * {item,-15} ===> {StringIsANumber.UsingCharIsDigitWithForEach(item)}");
		}
		Console.WriteLine("- - -\n");


		Console.WriteLine("Using Check Digits Manuallly:");
		foreach (var item in values)
		{
			Console.WriteLine($" * {item,-15} ===> {StringIsANumber.UsingCharIsBetween09(item)}");
		}
		Console.WriteLine("- - -\n");
	}
}