using System;

namespace Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(check_even(num) ? $"{num} is odd" : $"{num} is odd");
        }
        public static bool check_even(int num)
        {
            return (num % 2 == 0) ? true : false;
        }
    }
}
