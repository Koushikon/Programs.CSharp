using System;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Upcasting to Base class
             */
            Text text1 = new Text();
            Shape shape1 = text1;
            
            shape1.XPos = 150; // Accessing Base class member
            Console.WriteLine(shape1.XPos);
            /**
             * Downcasting
             */
            Shape shape2 = new Text();
            shape2.YPos = 256;
            Console.WriteLine(shape2.YPos);

            // Explicit casting
            Text text2 = shape1 as Text;
            Text text3 = (Text)shape2;
            Console.WriteLine(text2.XPos);
            Console.WriteLine(text3.YPos);
        }
    }
}
