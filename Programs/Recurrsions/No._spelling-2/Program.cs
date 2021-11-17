using System;

/*************
 * Number Spelling Recurrsion Program
 * Time Complexity: O(number of digits), i.e. O(log n)
 * Space Complexity: O(n)
*************/

namespace Exponent
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.Write("Enter the numebr: ");
            string userInput = Console.ReadLine();
            number = Convert.ToInt32(userInput);

            // Calling the method
            string no_in_words = get_spelled(number);
            Console.WriteLine($"The {number} in words is {no_in_words}.");
        }

        static string spellings(int num)
        {
            switch (num)
            {
                case 0:
                    return "Zero";
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                case 9:
                    return "Nine";
                default:
                    return "Invalid number.";
            }
        }

        static string get_spelled(int full_num)
        {
            if (full_num <= 9)
                return spellings(full_num);
            return get_spelled(full_num / 10) + " " + spellings(full_num % 10);
        }
    }
}
