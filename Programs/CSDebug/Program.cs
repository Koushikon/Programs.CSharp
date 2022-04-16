using System;
using System.Collections.Generic;

namespace CSDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int> { 1, 2};
            var smallest = GetSmallest(new List<int> { 5, 6, 2, 1 }, 3);

            foreach (int val in smallest)
            {
                Console.Write($"{val}  ");
            }
            Console.WriteLine();
        }

        private static List<int> GetSmallest(List<int> nums, int v)
        {
            if (nums == null)
                throw new ArgumentNullException("list", "List is null here");
            if (v > nums.Count || v <= 0)
                throw new ArgumentOutOfRangeException("count",
                    "Count Must be between 1 to No. of elements in the List.");

            var buffer_nums = new List<int>(nums);
            var results = new List<int>();

            while (results.Count < v)
            {
                var min = GetSmallest(buffer_nums);
                results.Add(buffer_nums[min]);
                buffer_nums.RemoveAt(min);
            }

            return results;
        }

        private static int GetSmallest(List<int> nums)
        {
            int min = 0; // Storing first value

            for (int i= 1; i < nums.Count; i++)
            {
                if (nums[i] < nums[min])
                {
                    min = i; // Assigning index
                }
            }

            return min;
        }
    }
}