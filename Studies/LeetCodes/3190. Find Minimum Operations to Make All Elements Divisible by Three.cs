namespace Studies.LeetCodes;
public static class _3190
{
    public static int MinimumOperations()
    {
        int[] nums = [1, 2, 3, 4];
        int value = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if ((nums[i] + 1) % 3 == 0)
                value++;

            if ((nums[i] - 1) % 3 == 0)
                value++;
        }
        return value;
    }
}