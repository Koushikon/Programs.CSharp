using System;

/*************
 * Number Spelling Recurrsion Program
 * Time Complexity: O(number of digits), i.e. O(log n)
 * Space Complexity: O(n)
*************/

namespace No_spelling_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numebr: ");

            // We're using string? this means string type can be null
            string userInput = Console.ReadLine();
            // For C# 10
            // string? userInput = Console.ReadLine();

            int size = userInput.Length;
            // For C# 10
            // int size = userInput?.Length ?? 0;

            int num = Convert.ToInt32(userInput);
            int len = userInput!.Length;

            // Calling the method
            string no_in_words = get_spelled(userInput, len - 1);
            Console.WriteLine($"The {userInput} in words is {no_in_words}.");
        }

        static string spellings(char num)
        {
            switch (num)
            {
                case '0':
                    return "Zero";
                case '1':
                    return "One";
                case '2':
                    return "Two";
                case '3':
                    return "Three";
                case '4':
                    return "Four";
                case '5':
                    return "Five";
                case '6':
                    return "Six";
                case '7':
                    return "Seven";
                case '8':
                    return "Eight";
                case '9':
                    return "Nine";
                default:
                    return "Invalid number.";
            }
        }
        static string get_spelled(string str, int len)
        {
            string spelled = "";
            if (len <= 0)
                return spellings(str[0]);
            spelled = get_spelled(str, len - 1) + " " + spellings(str[len]);
            return spelled;
        }
    }
}