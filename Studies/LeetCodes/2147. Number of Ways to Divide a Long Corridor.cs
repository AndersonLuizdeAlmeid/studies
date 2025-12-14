namespace Studies.LeetCodes;
public static class _2147
{
    public static int NumberOfWays()
    {
        string corridor = "SPPSSSSPPS";
        const int MOD = 1_000_000_007;

        int seatCount = 0;
        long ways = 1;
        int plantsAfterSecondSeat = 0;
        bool countingPlants = false;

        foreach (char c in corridor)
        {
            if (c == 'S')
            {
                seatCount++;

                if (seatCount % 2 == 0)
                {
                    countingPlants = true;
                    plantsAfterSecondSeat = 0;
                }
                else if (seatCount > 2)
                {
                    ways = (ways * (plantsAfterSecondSeat + 1)) % MOD;
                    countingPlants = false;
                }
            }
            else if (countingPlants)
            {
                plantsAfterSecondSeat++;
            }
        }

        if (seatCount < 2 || seatCount % 2 != 0)
            return 0;

        return (int)ways;
    }
}