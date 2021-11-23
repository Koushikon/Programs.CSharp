using System;

namespace Exponent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a power: ");
            int power = Convert.ToInt32(Console.ReadLine());

            int res = exponent(number, power);
            Console.WriteLine($"{number} to the power of {power} is {res}");
        }

        public static int exponent(int num, int pow)
        {
            int result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
