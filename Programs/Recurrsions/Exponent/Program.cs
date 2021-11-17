using System;

namespace Exponent
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0, power = 0;

            Console.Write("Enter the numebr: ");
            string userInput1 = Console.ReadLine();
            number = Convert.ToInt32(userInput1);

            Console.Write("Enter the numebr: ");
            string userInput2 = Console.ReadLine();
            power = Convert.ToInt32(userInput2);

            int val = get_exponent(number, power);
            Console.WriteLine($"{number} exponent {power} is {val}.");
        }
        static int get_exponent(int num, int pow)
        {
            if (pow <= 1)
                return num;
            return num * get_exponent(num, pow - 1);
        }
    }
}