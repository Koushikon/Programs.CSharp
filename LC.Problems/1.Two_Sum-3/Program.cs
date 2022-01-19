using System;
using System.Collections.Generic;

/**
 * * Two Sum Problem
 * * Nested Loop Solution
 * ? Time Complexcity: O(n)
 * ? Space Complexcity: O(n)
 */

static int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> isHave = new Dictionary<int, int>();
    int val = 0;

    for (int x = 0; x < nums.Length; x++)
    {
        if (isHave.TryGetValue(target - nums[x], out val))
        {
            return new int[] { val, x };
        }
        else if (!isHave.ContainsKey(nums[x]))
        {
            isHave.Add(nums[x], x);
        }

        // Console.WriteLine("{0} - {1} - {2}", nums[x], isHave[nums[x]], isHave.Count);
    }

    return new int[] { -1, -1 };
}

int[] numbers = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
int target_sum = 11;

int[] Twos = TwoSum(numbers, target_sum);

Console.WriteLine((Twos[0] >= 0) ?
    $"{Twos[0]} {Twos[1]} - {numbers[Twos[0]]} {numbers[Twos[1]]}" :
    "Not found.");

