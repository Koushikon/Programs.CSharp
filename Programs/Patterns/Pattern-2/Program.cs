using System;

namespace Pattern_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (byte i = 0; i <= 10; ++i)
            {
                for (byte j = 1; j <= 10 - i; ++j)
                    Console.Write(" * ");
                Console.WriteLine();
            }
        }
    }
}
