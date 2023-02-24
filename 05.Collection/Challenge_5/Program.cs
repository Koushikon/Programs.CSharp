using System;
using System.Collections.Generic;

static string[] take_input()
{
    Console.Write("Enter the number: ");
    string[] userInput = Console.ReadLine().Split(',');
    return userInput;
}

string[] S_nums = null;

do
{
    S_nums = take_input();

} while (S_nums.Length < 5);

int[] nums = Array.ConvertAll(S_nums, s => Convert.ToInt32(s));
Array.Sort(nums);

Console.WriteLine($"{nums[0]}  {nums[1]}  {nums[2]}");