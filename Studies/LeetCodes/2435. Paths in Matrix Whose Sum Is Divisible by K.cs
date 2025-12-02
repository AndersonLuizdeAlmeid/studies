using Studies.ListsAndLinkedLists;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Studies.LeetCodes;
public static class _2435
{
    public static int NumberOfPaths()
    {
        int[][] grid = [[5, 2, 4], [3, 0, 5], [0, 7, 2]];
        int k = 3;
        int m = grid.Length;
        int n = grid[0].Length;
        int MOD = 1_000_000_007;

        int[,,] dp = new int[m, n, k];

        dp[0, 0, grid[0][0] % k] = 1;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 && j == 0) continue;

                int val = grid[i][j] % k;

                for (int r = 0; r < k; r++)
                {
                    int newRem = (r + val) % k;

                    long ways = 0;

                    if (i > 0)
                    {
                        ways += dp[i - 1, j, r];
                    }

                    if (j > 0)
                    {
                        ways += dp[i, j - 1, r];
                    }

                    dp[i, j, newRem] = (int)((dp[i, j, newRem] + ways) % MOD);
                }
            }
        }
      
        Console.WriteLine(dp[m - 1, n - 1, 0]);
        return dp[m - 1, n - 1, 0];
    }
}