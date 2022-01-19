using System;

namespace Counting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Get counting like 1 2 3 4 5
            get_counting(number);

            // Get counting like 5 4 3 2 1
            get_rev_counting(number);
        }

        public static void get_counting(int num)
        {
            for (int i = 1; i <= num; ++i)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static void get_rev_counting(int num)
        {
            for (int i = num; i >= 1; --i)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
