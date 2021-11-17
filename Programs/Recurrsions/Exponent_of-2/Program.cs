using System;

namespace Exponent_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0, power = 0;

            Console.Write("Enter the 2 Exponent numebr: ");
            string userInput = Console.ReadLine();
            number = Convert.ToInt32(userInput);

            int val = get_2_exponent(number);
            Console.WriteLine($"2's exponent {power} is {val}.");
        }
        static int get_2_exponent(int num)
        {
            if (num == 1)
                return 1;
            int small_answer = get_2_exponent(num / 2);
            if (num & 1)
                return small_answer * small_answer * 2;
            else
                return small_answer * small_answer;
        }
    }
}
