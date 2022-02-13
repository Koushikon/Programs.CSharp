using System;

/**
 * * Function Declaration in C#
 */

namespace Function_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The Summation value is {add(7, 9)}");
            Console.WriteLine($"The Subtraction value is {sub(70, 9)}");
            Console.WriteLine($"The Multiplication value is {mul(7, 5)}");
            Console.WriteLine($"The Division value is {div(25, 6)}");
            Console.WriteLine($"The Reminder value is {rem(28, 6)}");

            Console.WriteLine($"The Concatinate value is {concat("Namaskar", "Cooch Behar")}");
        }

        static int add(int a, int b)
        {
            return a + b;
        }

        static int sub(int a, int b)
        {
            return a - b;
        }

        static int mul(int a, int b)
        {
            return a * b;
        }

        static double div(double a, double b)
        {
            return a / b;
        }

        static int rem(int a, int b)
        {
            return a % b;
        }

        static string concat(string a, string b)
        {
            return a + ' ' + b;
        }
    }
}
