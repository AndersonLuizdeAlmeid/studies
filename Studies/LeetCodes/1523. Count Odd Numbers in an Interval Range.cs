namespace Studies.LeetCodes;
public static class _1523
{
    public static int CountOdds()
    {
        int low = 8;
        int high = 10;
        int count = 0;

        count = (high - low) / 2;

        if (low % 2 == 1)
            count++;

        if (high % 2 == 1)
            count++;

        if(low % 2 == 1 && high % 2 == 1)
            count--;

        return count;
    }
}