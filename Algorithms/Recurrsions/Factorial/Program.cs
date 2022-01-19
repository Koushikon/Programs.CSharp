using System;

/*************
 * Factorial Recurrsion Program
 * Time Complexity: O(n)
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
            sum = get_factorial(num);
            Console.WriteLine($"= {sum}");
        }
        static int get_factorial(int n)
        {
            Console.Write($"{n} ");
            if (n <= 1)
                return n;
            return n * get_factorial(n - 1);
        }
    }
}
