using System;
using System.Collections.Generic;

/**
 * * Asking for 5 Unique input
 */

static int take_input(bool staus)
{
    if (staus)
        Console.Write("Its already there, Try again: ");
    else
        Console.Write("Enter the number: ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

static bool check_for_number(List<int> nums_list, int num)
{
    foreach (int n in nums_list)
    {
        if (n == num)
            return true;
    }
    return false;
}

List<int> numbers = new List<int>();
int num = 0;
int i = 0;
bool status = false;

do
{
    num = take_input(status);

    status = check_for_number(numbers, num);
    if (num > 0 && !status)
    {
        numbers.Add(num);
        // Console.WriteLine(num);
        i++;
    }
    else
        status = true;
} while (i < 5);

numbers.Reverse();
Console.WriteLine(string.Join(' ', numbers));