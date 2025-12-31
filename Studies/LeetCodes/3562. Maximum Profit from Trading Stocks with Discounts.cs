namespace Studies.LeetCodes;
public static class _3562
{
    static int n;
    static int[] present;
    static int[] future;
    static int budget;
    static Dictionary<int, List<int>> tree;

    public static int MaxProfit()
    {

        n = 2;
        present = new[] { 1, 2 };
        future = new[] { 4, 3 };
        int[][] hierarchy = { new[] { 1, 2 } };
        budget = 3;

        tree = new Dictionary<int, List<int>>();
        for (int i = 1; i <= n; i++)
            tree[i] = new List<int>();

        foreach (var h in hierarchy)
            tree[h[0]].Add(h[1]);

        var dp = Dfs(1);

        int result = 0;
        for (int b = 0; b <= budget; b++)
            result = Math.Max(result, dp.noDiscount[b]);

        return result;
    }

    // Retorna:
    // noDiscount -> pai não comprou
    // withDiscount -> pai comprou
    static (int[] noDiscount, int[] withDiscount) Dfs(int node)
    {
        int[] dpNo = new int[budget + 1];
        int[] dpYes = new int[budget + 1];

        Array.Fill(dpNo, int.MinValue);
        Array.Fill(dpYes, int.MinValue);
        dpNo[0] = dpYes[0] = 0;

        foreach (var child in tree[node])
        {
            var childDp = Dfs(child);

            dpNo = Merge(dpNo, childDp.noDiscount);
            dpYes = Merge(dpYes, childDp.withDiscount);
        }

        int costFull = present[node - 1];
        int costHalf = costFull / 2;
        int profitFull = future[node - 1] - costFull;
        int profitHalf = future[node - 1] - costHalf;

        int[] newNo = (int[])dpNo.Clone();
        int[] newYes = (int[])dpYes.Clone();

        for (int b = budget; b >= costFull; b--)
            if (dpNo[b - costFull] != int.MinValue)
                newNo[b] = Math.Max(newNo[b], dpNo[b - costFull] + profitFull);

        for (int b = budget; b >= costHalf; b--)
            if (dpYes[b - costHalf] != int.MinValue)
                newYes[b] = Math.Max(newYes[b], dpYes[b - costHalf] + profitHalf);

        return (newNo, newYes);
    }

    static int[] Merge(int[] a, int[] b)
    {
        int[] res = new int[budget + 1];
        Array.Fill(res, int.MinValue);

        for (int i = 0; i <= budget; i++)
        {
            if (a[i] == int.MinValue) continue;
            for (int j = 0; j + i <= budget; j++)
            {
                if (b[j] == int.MinValue) continue;
                res[i + j] = Math.Max(res[i + j], a[i] + b[j]);
            }
        }

        return res;
    }
}