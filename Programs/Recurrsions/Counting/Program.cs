using System;

/*************
 * Counting Recurrsion Program
 * Time Complexity: O(n)
 * Space Complexity: O(n)
*************/

int num = 0;
string userInput;

Console.Write("Enter the numebr: ");
userInput = Console.ReadLine();
num = Convert.ToInt32(userInput);

get_counting(num);
rev_get_counting(num);
Console.WriteLine("\n");
both_counting_at_once(num);

void get_counting(int n)
{
    if (n <= 0)
        return;
    Console.Write($"{n} ");
    get_counting(n - 1);
}

void rev_get_counting(int n)
{
    if (n <= 0)
        return;
    rev_get_counting(n - 1);
    Console.Write($"{n} ");
}

void both_counting_at_once(int n)
{
    if (n <= 0)
        return;
    Console.Write($"{n} ");
    both_counting_at_once(n - 1);
    Console.Write($"{n} ");
}