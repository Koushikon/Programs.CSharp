using System;

/**
 * * Match the Pattern:
 * * 1
 * * 4  6
 * * 9  11 13
 * * 17 19 21 23
 */

namespace Pattern_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int OudetLoop = 7, PrintVal = 1;

            for (int i = 1; i <= OudetLoop; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{PrintVal} ");
                    PrintVal += 2;
                }

                PrintVal += (i % 3 == 0) ? 2 : 1;
                Console.WriteLine();
            }
        }
    }
}
