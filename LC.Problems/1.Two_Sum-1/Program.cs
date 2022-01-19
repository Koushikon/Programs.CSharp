using System;

/**
 * * Two Sum Problem
 * * Nested Loop Solution
 * ? Time Complexcity: O(n^2)
 * ? Space Complexcity: O(1)
 */

static int[] TwoSum(int[] nums, int target)
{
    int[] num_list = new int[2] { -1, -1 };
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                num_list[0] = i;
                num_list[1] = j;
            }
        }
    }

    Console.WriteLine("{0} {1}", num_list[0], num_list[1]);
    return num_list;
}

int[] numbers = new int[] { 7, 12, 15, 16, 20 };
int target_sum = 36;

int[] Twos = TwoSum(numbers, target_sum);

Console.WriteLine((Twos[0] >= 0) ? $"{numbers[Twos[0]]} {numbers[Twos[0]]}" : "Not found.");


