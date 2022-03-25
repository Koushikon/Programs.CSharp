public class Addiction
{
    public int Add(params int[] nums)
    {
        int res = 0;
        foreach (var val in nums)
            res += val;
        return res;
    }
}