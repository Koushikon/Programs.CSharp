using System;

/*************
 * Fibonacci Recurrsion Program
 * Time Complexity: 2^n
 * Space Complexity: O(n)
*************/

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, sum = 1;

            Console.Write("Enter the numebr: ");
            // We're using string? this means string type can be null
            string? userInput = Console.ReadLine();
            num = Convert.ToInt32(userInput);

            Console.Write("Factorial ");
            sum = get_fibonacci(num);
            Console.WriteLine($"The factorial of {num}th position is = {sum}.");
        }
        static int get_fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return get_fibonacci(n - 1) + get_fibonacci(n - 2);
        }
    }
}
