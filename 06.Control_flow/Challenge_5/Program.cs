using System;

/**
 * * Find Max Number
 */

static int max_number(int[] nums)
{
    int max = nums.Length - 1;
    for (int i = 0; i < nums.Length - 1; i++)
    {
        if (nums[i] > nums[max])
        {
            // Console.WriteLine("{0} {1}", i, max);
            max = i;
        }
    }
    return max;
}

string[] userInputs = Console.ReadLine().Split(',');
int[] numbers = Array.ConvertAll(userInputs, s => int.Parse(s));

Console.WriteLine(string.Join(' ', numbers));
Console.WriteLine($"The Max number is: {numbers[max_number(numbers)]}");
