namespace Studies.LeetCodes;
public static class _1015
{
    public static int SmallestRepunitDivByK()
    {
        int k = 1;
        int n = 0; 

        for (int i = 1; i <= k; i++)
        {
            n = (n * 10 + 1) % k;
            if (n == 0)
            {
                return i;
            }
        }

        return -1;
    }
}