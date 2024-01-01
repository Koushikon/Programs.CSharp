using System.Globalization;
using System.Text.RegularExpressions;

namespace Matrix;

public partial class StringIsANumber
{
	public static bool IntTryParse(string value)
	{
		return int.TryParse(value, out _);
	}

	public static bool DoubleTryParse(string value)
	{
		return double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out _);
	}

	public static bool UsingRegex(string value)
	{
		const string pattern = @"^-?[0-9]+(?:\.[0-9]+)?$";
		var regex = new Regex(pattern);

		return regex.IsMatch(value);
	}

	[GeneratedRegex(@"^-?[0-9]+(?:\.[0-9]+)?$")]
	private static partial Regex IsDigitRegex();

	public static bool UsingCompiledRegex(string value)
	{
		return IsDigitRegex().IsMatch(value);
	}

	public static bool UsingCharIsDigit(string value)
	{
		return value.All(char.IsAsciiDigit);
	}

	public static bool UsingCharIsDigitWithForEach(string value)
	{
		foreach (var c in value)
		{
			if(!char.IsAsciiDigit(c))
				return false;
		}

		return true;
	}

	public static bool UsingCharIsBetween09(string value)
	{
		foreach (var c in value)
		{
			if (c is < '0' or > '9')
				return false;
		}

		return true;
	}
}