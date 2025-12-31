namespace Studies.LeetCodes;
public static class _2110
{
    public static long GetDescentPeriods()
    {
        int[] prices = [3, 2, 1, 4];
        long result = 0;

        for(int i = 0 , j = 0; j < prices.Length; j++)
        {
            if (j > 0 && prices[j] != prices[j - 1] - 1)
            {
                i = j;
            }
            result += j - i + 1;
        }


        return result;
    }
}