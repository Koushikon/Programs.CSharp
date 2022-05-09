using System;

namespace Plus_One
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            var res = new int[digits.Length + 1];
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] += 1;
                if (digits[i] > 9)
                    continue;
                else
                    break;
            }
            return digits;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[1] { 9 };
            Solution s1 = new Solution();
            var result = s1.PlusOne(arr);
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
