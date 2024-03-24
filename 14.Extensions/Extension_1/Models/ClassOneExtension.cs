using Extension_1.Models;

namespace Extension_1.Models;

/***
 * * C# Extension method is a static method of a static class,
 * * where the "this" modifier is applied to the first parameter.
 * * The type of the first parameter will be the type that is extended.
 */

public static class ClassOneExtension
{
    public static void GetData(this ClassOne classOne)
    {
        Console.WriteLine($"Class is {nameof(classOne)}.");
    }

    public static int IntConvert(this string str)
    {
        return int.Parse(str);
    }
}