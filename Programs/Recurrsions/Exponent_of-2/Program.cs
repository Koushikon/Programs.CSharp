using System;

/*************
 * Exponent of 2 Recurrsion Program
 * Time Complexity: O(log n), i.e. powwer
 * Space Complexity: O(n)
*************/

namespace Exponent_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = 0;

            Console.Write("Enter the 2 Exponent numebr: ");
            string userInput = Console.ReadLine();
            power = Convert.ToInt32(userInput);

            int val = get_2_exponent(power);
            Console.WriteLine($"2's exponent {power} is {val}.");
        }
        static int get_2_exponent(int num)
        {
            if (num == 0)
                return 1;
            int small_answer = get_2_exponent(num / 2);
            if (num % 2 == 1)
                return small_answer * small_answer * 2;
            else
                return small_answer * small_answer;
        }
    }
}
