using System;

/**
 * * Two Sum Problem
 * * Nested Loop Solution
 * ? Time Complexcity: O(nlogn)
 * ? Space Complexcity: O(1)
 */

static int[] TwoSum(int[] nums, int target)
{
    Array.Sort(nums); // Sorted Array;
    int left = 0;
    int right = nums.Length - 1;
    int sum;

    for (int i = 0; i < nums.Length; i++)
    {
        sum = nums[left] + nums[right];
        if (sum > target)
        {
            right -= 1;
        }
        else if (sum < target)
        {
            left += 1;
        }
        else
        {
            // Console.WriteLine("{0} {1}", left, right);
            return new int[] { left, right };
        }
    }

    return new int[] { -1, -1 };
}

int[] numbers = new int[] { 3, 2, 4 };
int target_sum = 6;

int[] Twos = TwoSum(numbers, target_sum);

Console.WriteLine((Twos[0] >= 0) ? $"{numbers[Twos[0]]} {numbers[Twos[1]]}" : "Not found.");
