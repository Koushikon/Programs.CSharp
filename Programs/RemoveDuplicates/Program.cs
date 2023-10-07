
namespace ConsoleApp1;

internal class Program
{
    public static void Main()
    {
        int[] nums = new int[] { 1, 2, 2, 3, 3, 5, 5, 6 };
        // int[] nums = new int[] { 0, 2, 2, 3 };

        Solution solution = new();
        Console.WriteLine(solution.GetUniqueLength1(nums));
        Console.WriteLine(solution.GetUniqueLength2(nums));
    }
}

public class Solution
{
    public int GetUniqueLength1(int[] value)
    {
        if (value.Length == 0)
        {
            return 0;
        }

        List<int> uniqueArr = new();
        for (int i = 0; i < value.Length; i++)
        {
            if (uniqueArr.Count == 0 || uniqueArr.Last() != value[i])
            {
                uniqueArr.Add(value[i]);
            }
        }
        return uniqueArr.Count;
    }

    public int GetUniqueLength2(int[] value)
    {
        if (value.Length == 0)
        {
            return 0;
        }

        int arraylength = 1;
        int lastValue = value[0];

        for (int i = 1; i < value.Length; i++)
        {
            if (lastValue != value[i])
            {
                arraylength++;
                lastValue = value[i];
            }
        }
        return arraylength;
    }
}