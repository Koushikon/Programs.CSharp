using System;
using Structs.Math;

namespace Structs
{
    // Structs are like classes, but they are value types.
    // Use Structs when we want to define a small lightweight object that we want to pass around.
    // Whatever we create in Structs, we can create the same in Classes.
    public struct Color
    {
        public int Red;
        public int Green;
        public int Blue;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Just like Classes, we can create an object of the struct Color
            // Instance of the struct Color
            Color color = new Color();

            color.Red = 240;
            color.Green = 24;
            color.Blue = 36;

            Console.WriteLine("Red: {0}", color.Red);
            Console.WriteLine("Green: {0}", color.Green);
            Console.WriteLine("Blue: {0}", color.Blue);

            // We can also create an object of the struct Calculator
            // Instance of the struct Calculator
            Calculator calculator = new Calculator();
            int result = calculator.Add(9, 3);
            Console.WriteLine(result);
        }
    }
}
