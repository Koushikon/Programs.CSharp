using System;

/**
 * * Bubble Sort Program
 */

static int[] Bubble_sort_sb(int[] nums)
{
    // It is working smallest to Biggest
    for (int i = 0; i < nums.Length - 1; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            // Console.WriteLine("{0} {1}", nums[i], nums[j]);
            if (nums[i] > nums[j])
            {
                int temp = nums[j];
                nums[j] = nums[i];
                nums[i] = temp;
            }
            // Console.WriteLine("{0} {1}", nums[i], nums[j]);
        }
    }
    return nums;
}

static int[] Bubble_sort_bs(int[] nums)
{
    // It is working Biggest to smallest
    for (int i = 0; i < nums.Length - 1; i++)
    {
        for (int j = 0; j < nums.Length - i - 1; j++)
        {
            if (nums[j] > nums[j + 1])
            {
                int temp = nums[j + 1];
                nums[j + 1] = nums[j];
                nums[j] = temp;
            }
        }
    }
    return nums;
}

int[] numbers = new int[] { 7, 5, 15, 2, 4, 8, 33, 4, 64, 34, 25, 12, 22, 11, 90 };
Console.WriteLine(string.Join(' ', numbers));

numbers = Bubble_sort_sb(numbers);
Console.WriteLine("Sorted Array: {0}", string.Join(' ', numbers));

numbers = new int[] { 7, 5, 15, 2, 4, 8, 33, 4, 64, 34, 25, 12, 22, 11, 90 };
numbers = Bubble_sort_bs(numbers);
Console.WriteLine("Sorted Array: {0}", string.Join(' ', numbers));