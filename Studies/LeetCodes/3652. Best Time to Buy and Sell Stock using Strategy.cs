namespace Studies.LeetCodes;
public static class _3652
{
    public static long MaxProfit()
    {
        int[] prices = [4, 2, 8];
        int[] strategy = [-1, 0, 1];
        int k = 2;

        int n = prices.Length;
        long baseProfit = 0;

        // 1. Calculate the base profit with the current strategy
        for (int i = 0; i < n; i++)
        {
            baseProfit += (long)prices[i] * strategy[i];
        }

        // 2. We want to find the modification that gives the BEST increase.
        // We initialize maxDelta to 0 because we might choose NOT to modify.
        long maxDelta = 0;
        long currentDelta = 0;
        int mid = k / 2;

        // 3. Calculate delta for the first window starting at index 0
        for (int i = 0; i < k; i++)
        {
            long originalValue = (long)prices[i] * strategy[i];
            long newValue = (i < mid) ? 0 : (long)prices[i];
            currentDelta += (newValue - originalValue);
        }

        // Check first window against 0
        maxDelta = Math.Max(maxDelta, currentDelta);

        // 4. Slide the window
        for (int i = 1; i <= n - k; i++)
        {
            // A. Remove the element that just left the window (index i-1)
            // It was in the 'Hold' section (newValue = 0)
            long leftOutOriginal = (long)prices[i - 1] * strategy[i - 1];
            currentDelta -= (0 - leftOutOriginal);

            // B. The 'Middle' Shift
            // The element at (i + mid - 1) moves from 'Sell' to 'Hold'
            int midIdx = i + mid - 1;
            currentDelta -= (long)prices[midIdx]; // It was +price, now it's 0

            // C. Add the new element entering on the right (index i+k-1)
            // It enters the 'Sell' section (newValue = price)
            int rightInIdx = i + k - 1;
            long rightInOriginal = (long)prices[rightInIdx] * strategy[rightInIdx];
            currentDelta += ((long)prices[rightInIdx] - rightInOriginal);

            // Update maxDelta
            maxDelta = Math.Max(maxDelta, currentDelta);
        }

        return baseProfit + maxDelta;
    }
}