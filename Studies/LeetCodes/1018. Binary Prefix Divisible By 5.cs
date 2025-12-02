namespace Studies.LeetCodes;
public static class _1018
{
    public static IList<bool> PrefixesDivBy5()
    {
        int[] nums = [0, 1, 1, 1];
        bool[] result = new bool[nums.Length];

        int prefix = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            prefix = ((prefix << 1) + nums[i]) % 5;
            result[i] = prefix == 0;
        }

        return result;
    }
}