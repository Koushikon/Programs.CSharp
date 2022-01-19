using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the position ");
            int position = Convert.ToInt32(Console.ReadLine());

            int result = get_fibonacci(position);
            Console.WriteLine($"The {position}th fibonacci is {result}");
        }

        public static int get_fibonacci(int pos)
        {
            int fib0 = 0, fib1 = 1;
            int res = 0;
            for (int i = 2; i <= pos; ++i)
            {
                res = fib0 + fib1;
                fib0 = fib1;
                fib1 = res;
            }
            return res;
        }
    }
}
