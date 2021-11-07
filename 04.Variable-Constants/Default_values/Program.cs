using System;

/// <summary>
/// Assigning the default value of Different types
/// @source: https://www.pluralsight.com/guides/automatic-default-values-for-variables-in-c
/// </summary>

namespace Default_values
{
    class Program
    {
        static void Main(string[] args)
        {
            /*************
            * Default values
            *************/

            // With default(Type) we can assign the default value of a type
            int a = default(int);

            // With only default keyword
            int b1 = default;
            float b = default;
            double c = default;
            string d = default;
            var e = new System.Collections.ArrayList();

            // nameof() function returns the name of the variable
            Console.WriteLine($"The variable: {nameof(a)} has value: {a}");
            Console.WriteLine($"The variable: {nameof(b)} has value: {b}");
            Console.WriteLine($"The variable: {nameof(b1)} has value: {b1}");
            Console.WriteLine($"The variable: {nameof(c)} has value: {c}");
            Console.WriteLine($"The variable: {nameof(d)} has value: {d}");
            Console.WriteLine($"The variable: {nameof(e)} has value: {e}");

            Console.Write("Enter any key...");
            Console.ReadKey();
        }
    }
}
