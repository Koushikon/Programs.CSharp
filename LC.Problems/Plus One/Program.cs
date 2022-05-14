using System;
using System.Text;


namespace Plus_One
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            var num = Convert.ToInt32(string.Join("", digits)) + 1;
            // var strArray = num.ToString().Split("");
            // Console.WriteLine(num);
            // var res = Array.ConvertAll<string, int>(strArray, int.Parse);

            StringBuilder sb1 = new StringBuilder();
            while (num < 0)
            {
                sb1 = (num % 10).ToString();
            }
            Console.WriteLine(sb1);
            return digits;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3] { 9, 1, 3 };
            Solution s1 = new Solution();
            var result = s1.PlusOne(arr);
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
