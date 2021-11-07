using System;

namespace Sample_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("= = = Start = = =");

            // Single line comment with "//"
            Console.Write("Hellow World");

            /*
             * Multiline Comments with
            */
            Console.Write("Hellow ");
            Console.WriteLine("World");

            Console.WriteLine("= = = = = = =");
            
            Console.Write("Hellow World");
            Console.WriteLine(" Apna");
            Console.Write(" Time\n");
            Console.Write("Nice\nMetting\nhere\n");

            Console.WriteLine("= = = = = = =");
            
            int value = 10;
			Console.WriteLine(value); // Variable
			Console.WriteLine(50.05); // Literal

            int val = 55;
			Console.WriteLine("Dotnet " + "C#");
			Console.WriteLine("Value = " + val);

            Console.WriteLine("= = = = = = =");

            int firstNumber = 5, secondNumber = 10, result;
			result = firstNumber + secondNumber;
			Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);

            Console.WriteLine("= = = End = = =");
        }
    }
}
