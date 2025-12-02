namespace Studies.LeetCodes;
public static class _3381
{
    public static long MaxSubarraySum()
    {
        int[] nums = [-1, -2, -3, -4, -5];
        int k = 4;
        int sum = 0;

        nums.OrderDescending();

        for (int i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        Console.WriteLine(sum);
        return sum;
    }
}