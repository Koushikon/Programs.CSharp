using System;

/**
 * * Function Declaration with default arguments in C#
 */

namespace Function_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Greeting in Bengali {join("Namaskar")}");
            Console.WriteLine($"Greeting in Bengali an ex. {join("Namaskar", "Bikash")}");

            Console.WriteLine($"Greeting in Hindi {join("Namaste")}");
            Console.WriteLine($"Greeting in Hindi an ex. {join("Namaste", "Asutosh")}");
        }

        // We if didn't provide any argument when calling
        // The default argument will work here.
        static string join(string a = "Hello", string b = "")
        {
            if (string.IsNullOrWhiteSpace(b))
                return a;
            else
                return a + ' ' + b;
        }
    }
}
