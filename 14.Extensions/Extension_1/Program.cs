using Extension_1.Models;

namespace Extension_1;

public class Program
{
    static void Main()
    {
        /***
         * * use Built-in extension methods example
         * *
         * * most common extension methods are the LINQ standard query operators that add query functionality to
         * * the existing System.Collections.IEnumerable and System.Collections.Generic.IEnumerable<T> types.
         */
        int[] ints = [10, 45, 15, 39, 21, 26];
        var result = ints.OrderBy(g => g);
        foreach (var i in result)
        {
            System.Console.Write(i + " ");
        }
        Console.WriteLine();


        // User defined extension methods example
        ClassOne classOne = new();
        classOne.GetData(); // We can use extension methods as class object method
        ClassOneExtension.GetData(classOne);    // We can use extension methods as static class method


        string str_number = "456789";
        int number = str_number.IntConvert();   // We can use extension methods as class object method
        Console.WriteLine("Convert to as " + number);

        number = ClassOneExtension.IntConvert(str_number);  // We can use extension methods as static class method
        Console.WriteLine("Convert to as " + number);

        Console.WriteLine("End of world.");
    }
}