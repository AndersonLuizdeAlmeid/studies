namespace Studies.LeetCodes;
public static class _1925
{
    public static int CountTriples()
    {
        int n = 18;
        int count = 0;

        for(int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                for (int k = 1; k <= n; k++)
                {
                    if(k == i || k == j)
                        continue;

                    if ((i * i) + (j * j) == k * k)
                        count++;
                }
            }
        }

        return count;
    }
}