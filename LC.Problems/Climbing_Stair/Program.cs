using System;

namespace Climbing_Stair
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            int first = 2, second = 3;
            if (n <= 3)
                return n;

            int res = 0;
            for (int i = 4; i <= n; i++)
            {
                res = first + second;
                first = second;
                second = res;
            }

            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution s1 = new Solution();
            var result = s1.ClimbStairs(10);
            Console.WriteLine(result);
        }
    }
}
