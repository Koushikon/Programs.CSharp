using System;

namespace Sample_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("= = = Start = = =");

            int value = 10;
            Console.WriteLine(value); // Variable
            Console.WriteLine(50.05); // Literal

            Console.WriteLine("= = = = = = =");

            Console.Write("Enter an Integer: ");
            string userInput1 = Console.ReadLine();
            Console.WriteLine($"You Entered: {userInput1}");

            Console.WriteLine("= = = = = = =");

            int num1 = 0;
            Console.Write("Enter the first Integer: ");
            string userInput2 = Console.ReadLine();
            num1 = Convert.ToInt32(userInput2);

            int num2 = 0;
            Console.Write("Enter the second Integer: ");
            string userInput3 = Console.ReadLine();

            // Converting the user input to an integer
            num2 = Convert.ToInt32(userInput3);
            // Printing the output with string interpolation
            Console.WriteLine($"You Entered: {num1} and {num2} their sum is {num1 + num2}");

            Console.WriteLine("= = = = = = =");

            float num3 = 7.9f;
            double num4 = 0.0;
            Console.WriteLine("Enter a double value: ");
            string userInput4 = Console.ReadLine();

            // Converting the user input to a double
            num4 = Convert.ToDouble(userInput4);
            // Printing the output with string interpolation
            Console.WriteLine($"You Entered: {num4} and the Float value is {num3}f");

            Console.WriteLine("= = = End = = =");
        }
    }
}
