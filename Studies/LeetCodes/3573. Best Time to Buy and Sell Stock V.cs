namespace Studies.LeetCodes;
public static class _3573
{
    public static long MaximumProfit()
    {
        int[] prices = [1, 7, 9, 8, 2];
        int k = 2;
        int n = prices.Length;
        long INF = -1_000_000_000_000_000L;

        long[,] prev = new long[k + 1, 3];
        long[,] curr = new long[k + 1, 3];

        for (int t = 0; t <= k; t++)
        {
            prev[t, 0] = INF;
            prev[t, 1] = INF;
            prev[t, 2] = INF;
        }
        prev[0, 0] = 0;

        foreach (int price in prices)
        {
            for (int t = 0; t <= k; t++)
            {
                curr[t, 0] = INF;
                curr[t, 1] = INF;
                curr[t, 2] = INF;
            }

            for (int t = 0; t <= k; t++)
            {
                long maxFlat = prev[t, 0];

                if (prev[t, 1] != INF)
                    maxFlat = Math.Max(maxFlat, prev[t, 1] + price);

                if (prev[t, 2] != INF)
                    maxFlat = Math.Max(maxFlat, prev[t, 2] - price);

                curr[t, 0] = maxFlat;

                if (t > 0)
                {
                    long maxBull = prev[t, 1];

                    if (prev[t - 1, 0] != INF)
                        maxBull = Math.Max(maxBull, prev[t - 1, 0] - price);

                    curr[t, 1] = maxBull;
                    long maxBear = prev[t, 2];

                    if (prev[t - 1, 0] != INF)
                        maxBear = Math.Max(maxBear, prev[t - 1, 0] + price);

                    curr[t, 2] = maxBear;
                }
            }

            Array.Copy(curr, prev, curr.Length);
        }

        long finalProfit = 0;
        for (int t = 0; t <= k; t++)
        {
            finalProfit = Math.Max(finalProfit, prev[t, 0]);
        }

        return finalProfit;
    }
}