using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = get_factorial(number);
            Console.WriteLine($"The {number}'s factorial is {result}");
        }

        public static int get_factorial(int num)
        {
            int res = num;

            while (num >= 2)
                res *= --num;

            return res;
        }


    }
}
