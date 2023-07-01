
namespace String_Conversion;

public class Program
{
    public static void Main(string[] args)
    {
        /*
         * int.Parse and Convert.ToInt32 returns the same result.
         * i.e. Except int.Parse throws an error for null.
         * and Convert.ToInt32 returns the 0 for null.
        */

        // Conversion of String to Int
        //int.Parse((string)null);  // throws exception
        //int.Parse("Hello");   // throws exception
        //int.Parse("1.5"); // throws exception
        int.Parse("7"); // Ok

        Convert.ToInt32((string)null);  // Ok
        //Convert.ToInt32("Hello"); // throws exception
        //Convert.ToInt32("1.5");   // throws exception
        Convert.ToInt32("7");   // Ok


        /*
         * To prevent Exception When Converting String to Int
         * i.e. Int.TryParse If conversion fails then returns 0.
        */

        string sdata = "hello";

        int iresult1;
        int.TryParse(sdata, out iresult1);
        Program.Print(iresult1);

        // Or, In Single line
        int.TryParse(sdata, out int iresult2);
        Program.Print(iresult2);

        /*
         * Extension of String to Int COnversion
        */
        string myString1 = "new";
        string myString2 = "new";
        string myString3 = null;

        int number1 = myString1.ParseInt(); // returns value or 0
        int number2 = myString2.ParseInt(-1);   // returnsdefault value -1
        int? number3 = myString3.ParseNullableInt(); // returns value or null

        Program.Print(number1);
        Program.Print(number2);
        Program.Print(number3);
    }

    private static void Print(object data)
    {
        Console.WriteLine(data);
    }
}

public static class IntegerExtension
{
    public static int ParseInt(this string value, int defaultIntValue = 0)
    {
        int parsedInt;
        if (int.TryParse(value, out parsedInt))
        {
            return parsedInt;
        }

        return defaultIntValue;
    }

    public static int? ParseNullableInt(this string value)
    {
        if (string.IsNullOrEmpty(value))
            return null;

        return value.ParseInt();
    }
}