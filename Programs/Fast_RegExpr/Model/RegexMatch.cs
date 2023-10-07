using System.Text.RegularExpressions;

namespace Fast_RegExpr.Model;

public static partial class RegexExamples
{
    [GeneratedRegex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
        RegexOptions.CultureInvariant)]
    public static partial Regex ContainsWordRegex();
}

public class RegexMatch
{
    private static readonly Regex _containsWordRegEx = new(pattern: @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", options: RegexOptions.CultureInvariant);

    // 1st Way: Previous
    public static bool ContainsWord_1(string input)
    {
        var expression = new Regex(
             pattern: @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
             options: RegexOptions.CultureInvariant);
        return expression.IsMatch(input);
    }

    // 2nd Way:
    public static bool ContainsWord_2(string input) => _containsWordRegEx.IsMatch(input);

    // 3rd Way: Fastest
    public static bool ContainsWord_3(string input) => RegexExamples.ContainsWordRegex().IsMatch(input);
}